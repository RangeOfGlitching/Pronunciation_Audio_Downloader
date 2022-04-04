import cambridge
import sys

result_filename = "[result].ini"


def check_dir(path):
    if not cambridge.os.path.exists(path):
        cambridge.os.makedirs(path)
    return path


# def search_word():
# user_input = input("download pronoun .mp3> ")
# if user_input == "":
#     return "quit"
# return user_input


def download_mp3(save_path, user_input, user_accent, user_speaking_rate):
    # user_input = search_word()

    # if user_input == "quit":
    #     return "quit"

    # user_input_cut_2 = user_input[0:2]
    user_input_cut_2 = user_input[0:2]
    url = f"http://ssl.gstatic.com/dictionary/static/pronunciation/2021-06-17/audio/{user_input_cut_2}/{user_input}_en_{user_accent}_{user_speaking_rate}.mp3"
    response = cambridge.requests.get(url)
    if response.status_code == cambridge.requests.codes.ok:
        path = cambridge.os.path.join(save_path,
                                      f"Google_{user_input}_{user_accent}_{user_speaking_rate}.mp3")
        with open(f"{path}", 'wb') as f:
            f.write(response.content)
            print(f"Google_{user_input}_{user_accent}_{user_speaking_rate}.mp3")
        with open(f"{result_filename}", "w") as f:
            f.write(f"save successfully\n")
            f.write(f"to {path}")

    elif response.status_code == 404:
        if not cambridge.search_cambridge(save_path, user_input, user_accent):
            with open(fr"{save_path}\fail.txt", "a+") as fail:
                fail.write(f"{user_input}\n")
                print("404 Not Found")

            with open(f"{result_filename}", "w") as fail:
                fail.write("404 NOT Found")
    else:
        with open(f"{result_filename}", "w") as f:
            f.write(f"error code=> {response.status_code}")


if __name__ == "__main__":
    if not len(sys.argv) == 5:
        # for index in sys.argv:
        #     print(f"{index} ")
        print("Please Follow the rules of [save_path] [searching_word] [accent:us/gb] [rate].")
        exit()
    sve_dir = check_dir(sys.argv[1])
    download_mp3(sve_dir, sys.argv[2], sys.argv[3], sys.argv[4])
    # python main.py F:\Pronunce\pronoumce_pro sewage gb 1

    # sys.argv[1] => for address
    # sys.argv[2] => for word
    # sys.argv[3] => for accent (us(usa) gb(gb))
    # sys.argv[4] => for speaking rate (1(normal) 2(slow))

    # home_dir = cambridge.cambridge.os.path.expanduser("~")
    # sve_dir = check_dir(home_dir + r"\Downloads\Pronunciation_Audio")
    # for index in sys.argv:
    #     print(f"{index} ")

    # print("Enter Empty to quit")
    # while True:
    #     if download_mp3(sve_dir) == "quit":
    #         break
