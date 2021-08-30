**Setup**

- execute `pip install locust` to install [locust](https://locust.io/) testing tool
- make sure that you have [docker](https://docs.docker.com/get-docker/) and [docker compose](https://docs.docker.com/compose/install/) installed
- setup the following environment vars:
  - LOCUST_TEST_API_ENDPOINT="YOUR_ENDPOINT_URL_GOES_HERE"
  - LOCUST_TEST_WAIT_START=1
  - LOCUST_TEST_WAIT_START=2
- execute `docker-compose up --scale worker=SET_DESIRED_NUMBER_OF_WORKERS_HERE`

Example: `docker-compose up --scale worker=4`

Open [http://localhost:8089/](http://localhost:8089/)