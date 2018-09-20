class Plateau(object):
    MIN_WIDTH = 0
    MIN_HEIGHT = 0

    def __init__(self, width, height, min_width=0, min_height=0):
        self.width = width
        self.height = height
        self.MIN_WIDTH = min_width
        self.MIN_HEIGHT = min_height

    def move_available(self, position):
        """

        :param Position position:
        :return:
        """
        return self.MIN_WIDTH <= position.x <= self.width and self.MIN_HEIGHT <= position.y <= self.height
