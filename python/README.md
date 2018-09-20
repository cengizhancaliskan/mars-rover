# Mars Rover Problem Solution with python 3
    This project must run python 3.x
# How to run ?
```bash
$ python run.py
```
# Docker
```bash
$ docker-compose up

If you run daemon mode 

$ docker-compose up -d
```

# Run in docker
```bash
$ docker-compose exec app python main.py
```

# Unittest
```bash
$ python -m unittest -v tests/test_mars_rover.py
```

# Run Unittest in docker
```bash
$ docker-compose exec app python -m unittest -v tests/test_mars_rover.py
```