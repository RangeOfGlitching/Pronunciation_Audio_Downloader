import requests
import os
import sys

result_filename = "[result].ini"

def check_dir(path):
    if not os.path.exists(path):
        os.makedirs(path)
    return path

# def search_word():
    #user_input = input("download pronoun .mp3> ")
    # if user_input == "":
    #     return "quit"
    # return user_input


def download_mp3(save_path, user_input):
    # user_input = search_word()

    # if user_input == "quit":
    #     return "quit"

    # user_input_cut_2 = user_input[0:2]
    user_input_cut_2 = user_input[0:2]
    url = f"http://ssl.gstatic.com/dictionary/static/pronunciation/2021-03-01/audio/{user_input_cut_2}/{user_input}_en_us_1.mp3"

    response = requests.get(url)
    if response.status_code == requests.codes.ok:
        path = os.path.join(save_path, f"{user_input}.mp3")
        with open(f"{path}", 'wb') as f:
            f.write(response.content)
        with open(f"{result_filename}", "w") as f:
            f.write(f"save successfully\n")
            f.write(f"to {path}")
            
    elif response.status_code == 404:
        with open(fr"{save_path}\fail.txt", "a+") as fail:
            fail.write(f"{user_input}\n")

        with open(f"{result_filename}", "w") as fail:
            fail.write("404 NOT Found")
    else:
        with open(f"{result_filename}", "w") as f:       
            f.write(f"error code=> {response.status_code}")


if __name__ == "__main__":
    #home_dir = os.path.expanduser("~")
    #sve_dir = check_dir(home_dir + r"\Downloads\Pronunciation_Audio")
    if not len(sys.argv) == 3:
        print ("Please Follow the rules of [path] [word].")
        exit()

    # for index in sys.argv:
    #     print(f"{index} ")
    sve_dir = check_dir(sys.argv[1])
    download_mp3(sve_dir, sys.argv[2])
    # print("Enter Empty to quit")
    # while True:
    #     if download_mp3(sve_dir) == "quit":
    #         break