from locust import HttpUser, between, task
import os

class WebsiteUser(HttpUser):
    wait_time = between(int(os.environ['LOCUST_TEST_WAIT_START']), int(os.environ['LOCUST_TEST_WAIT_END']))
        
    @task
    def index(self):
        self.client.get(os.environ['LOCUST_TEST_API_ENDPOINT'])

