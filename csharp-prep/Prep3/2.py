import itertools
import threading
import time
import sys

# Function to handle cycling through words
def cycle_words():
    words = ["Two's", "Too's", "To's"]
    for word in itertools.cycle(words):
        sys.stdout.write(f"\rThere are three {word} in the English language.")
        sys.stdout.flush()
        time.sleep(0.5)

# Function to handle stopping the loop on enter key press
def stop_loop():
    input()
    global running
    running = False

# Main program execution
running = True
t = threading.Thread(target=stop_loop)
t.start()

try:
    while running:
        cycle_words()
except KeyboardInterrupt:
    pass
finally:
    sys.stdout.write("\n")
    sys.stdout.flush()

