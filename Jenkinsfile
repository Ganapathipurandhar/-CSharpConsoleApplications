pipeline {
    agent any

    tools {
        msbuild 'MSBUILD'
    }

    stages {
       /* stage('Checkout') {
            steps {
                // Clone the Git repository
                script {
                    // Use credentials if required for private repositories
                    git branch: 'main', 
                        url: 'https://github.com/B-Aboobaker/CSharpConsoleApplications.git', 
                        credentialsId: 'git-credentials-id' // Replace with your Jenkins credential ID
                }
            }
        }*/

        stage('Restore') {
            steps {
                // Restore NuGet packages
                bat 'dotnet restore'
            }
        }

        stage('Build') {
            steps {
                // Build the project
                bat 'dotnet build --configuration Release'
            }
        }

        stage('Test') {
            steps {
                // Run tests (if the project contains tests)
                script {
                    def testProjects = bat(
                        script: "dir /s /b *.csproj | findstr /i test", 
                        returnStdout: true
                    ).trim().split("\n")
                    
                    if (testProjects) {
                        for (def project : testProjects) {
                            bat "dotnet test ${project} --no-restore --configuration Release"
                        }
                    } else {
                        echo 'No test projects found.'
                    }
                }
            }
        }

        stage('Package') {
            steps {
                // Publish the app
                bat 'dotnet publish -c Release -o out'
            }
        }

        stage('Archive') {
            steps {
                // Archive the output for deployment
                archiveArtifacts artifacts: 'out/**', fingerprint: true
            }
        }

        stage('Deploy') {
            steps {
                echo "Deploy stage can be customized to target environments like Azure, AWS, or on-prem."
                echo "For now, this pipeline completes the build and packaging stages."
            }
        }
    }

    post {
        success {
            echo 'Pipeline executed successfully!'
        }
        failure {
            echo 'Pipeline failed!'
        }
    }
}
