pipeline {
    agent any

    tools {
        msbuild 'MSBUILD'
    }

    environment {
        DOTNET_ROOT = 'C:/Program Files (x86)/Microsoft Visual Studio/2022/BuildTools/MSBuild/Current/Bin' // Adjust if using different Visual Studio version
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
                    bat 'dotnet restore PRG521.sln' 
                }
            }
        }

        stage('Build') {
            steps {
                // Build the project using .NET Framework 4.7
                echo "Building the project"
                dir('C:/Users/puran/OneDrive/Desktop/projects/CSharpConsoleApplications/PRG521') {
                bat 'dotnet build --configuration Release'
                }
            }
        }

        stage('Test') {
             steps {
               echo "testing the project"
                bat 'dotnet test C:\\Users\\puran\\OneDrive\\Desktop\\projects\\CSharpConsoleApplications\\PRG521\\PRG521\\PRG521.csproj --configuration Release'
             }   
       }
       stage('Publish') {
            steps {
                script {
                    // Publish the build output
                    bat 'dotnet publish C:\\Users\\puran\\OneDrive\\Desktop\\projects\\CSharpConsoleApplications\\PRG521\\PRG521\\PRG521.csproj --configuration Release --output C:\\Users\\puran\\OneDrive\\Desktop\\projects\\CSharpConsoleApplications\\target'
                }
             }   
    }


        stage('Archive') {
            steps {
                // Archive the output for deployment
                archiveArtifacts artifacts: '**/bin/Release/*', fingerprint: true
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
