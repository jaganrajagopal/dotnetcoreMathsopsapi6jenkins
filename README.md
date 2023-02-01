# dotnetcoreMathsopsapi6jenkins
dotnetcore with 6.0 for testing CI and CD pipeline using Jenkins 

For integration jenkins pipeline using dotnetcore application 

pipeline {
    agent any
    
    stages {
        stage('Clone Repository') {
            steps {
                git credentialsId: 'gitcredoutlook', url: 'https://github.com/jaganrajagopal/dotnetcoreMathsopsapi6jenkins.git' , branch :'main'
            }
        }
        stage('Build') {
            steps {
                bat  'dotnet build jenkinswithdotnet/MathAPI/MathAPI.csproj'
            }
        }
        stage('Test') {
            steps {
                bat  'dotnet test jenkinswithdotnet/MathsUnittestcase/MathsUnittestcase.csproj'
            }
        }
        stage('Deploy') {
            steps {
                bat  'dotnet publish jenkinswithdotnet/MathAPI/MathAPI.csproj --output deploy/'
            }
        }
    }
}
