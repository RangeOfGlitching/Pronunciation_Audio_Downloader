import requests
import os
from bs4 import BeautifulSoup
import requests.exceptions


def search_cambridge(path, user_input, En_Gb):
    base_url = "https://dictionary.cambridge.org"
    url = base_url + f"/us/dictionary/english/{user_input}"
    headers = {
        "user-agent": "Mozilla/5.0 (Windows NT 10.0; Win64; x64) AppleWebKit/537.36 (KHTML, like Gecko) "
                      "Chrome/91.0.4472.77 Safari/537.36"}

    try:
        response = requests.get(url=url, headers=headers).text
    except requests.exceptions as r:
        r.status_code = "Connection refused"
        return False

    soup = BeautifulSoup(response, "lxml")
    p = soup.findAll("source", type="audio/mpeg")

    if En_Gb == "us":
        index = 0
    elif En_Gb == "gb":
        index = 1
    else:
        index = 0

    try:
        download_url = base_url + p[index]["src"]
    except IndexError:
        return False
    try:
        download_response = requests.get(url=download_url, headers=headers)
    except requests.exceptions as r:
        r.status_code = "Connection refused"

        return False

    save_path = os.path.join(path, f"cambridge_{user_input}_{En_Gb}.mp3")
    with open(save_path, 'wb') as f:
        f.write(download_response.content)
        print(f"cambridge_{user_input}_{En_Gb}.mp3")
    # with open(f"{result_filename}", "w") as f:
    #     f.write(f"save successfully\n")
    #     f.write(f"to {save_path}")
    return True
