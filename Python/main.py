from marsrover import Plateau
from marsrover import Position
from marsrover import Rover


def main():
    plateau = Plateau(5, 5)
    position = Position(1, 2)
    # Create rover instance
    rover = Rover(plateau, position, Rover.DIRECTIONS.get('N'))
    rover.process("LMLMLMLMM")
    print(rover)  # prints 1 3 N

    rover.set_position(3, 3, Rover.DIRECTIONS.get('E'))
    rover.process("MMRMMRMRRM")
    print(rover)  # prints 5 1 E


if __name__ == "__main__":
    main()
