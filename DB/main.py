from PIL import Image

PATH = "Images/"
TARGET = ""


def div_img(name, num_w=10, num_h=2):
    suffix = "." + name.split(".")[-1]
    img = Image.open(PATH + name)
    width, height = img.size
    width /= num_w
    height /= num_h

    for i in range(num_w * num_h):
        left = i % num_w * width
        up = i // num_w * height
        cropped = img.crop((left, up, left + width, up + height))
        cropped.save(str(i) + suffix)


def main():
    name = "httpcloud3steamusercontentcomugc18504415283963332907EE5ABDF1A805DEF2A32EBA027990BE61BB2D7FB.png"

    div_img(name)


if __name__ == "__main__":
    main()
