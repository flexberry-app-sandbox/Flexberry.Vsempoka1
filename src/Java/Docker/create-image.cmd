docker build --no-cache -f SQL\Dockerfile.PostgreSql -t vsempoka-java/postgre-sql ../../SQL

docker build --no-cache -f Dockerfile -t vsempoka-java/app ../../..
