node {
 
    stage ('Checkout'){
        git 'git@github.com:tim-ilgiz/BsBackend.git'
    }
    stage ('Build'){
        sh 'sudo docker-compose -f docker-compose.ci.build.yaml up'
        sh 'sudo docker-compose -f docker-compose.ci.build.yaml down --remove-orphans'
    }
  
    stage 'Deploy'{
        sh 'sudo docker-compose down --remove-orphans'
        sh 'sudo docker-compose up -d --build'
        sh 'sudo docker ps -a | grep BsBackend'
    }
}