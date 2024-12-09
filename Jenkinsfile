pipeline {
    agent any

    tools {
        msbuild 'MSBUILD'
    }

    environment {
        DOTNET_ROOT = 'C:/Program Files (x86)/Microsoft Visual Studio/2019/BuildTools/MSBuild/Current/Bin' // Adjust if using different Visual Studio version
        PATH = "$DOTNET_ROOT:$PATH"
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
                // Restore NuGet packages from the solution or project file
                dir('C:/Users/puran/OneDrive/Desktop/projects/CSharpConsoleApplications/PRG521') {
                    bat 'dotnet restore PRG521.sln' // Replace with your solution or project file if different
                }
            }
        }

        stage('Build') {
            steps {
                // Build the project
                dir('C:/Users/puran/OneDrive/Desktop/projects/CSharpConsoleApplications/PRG521') {
                    bat 'dotnet build PRG521.sln --configuration Release' // Replace with your solution or project file if different
                }
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