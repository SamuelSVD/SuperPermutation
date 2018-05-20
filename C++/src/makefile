CC=g++
CFLAGS=-c
LDFLAGS=
SOURCES=main.cpp graph.cpp superperm.cpp
OBJECTS=$(SOURCES:.cpp=.o)

EXECUTABLE=proj.exe

all: $(SOURCES) $(EXECUTABLE)

$(EXECUTABLE): $(OBJECTS)
	$(CC) $(LDFLAGS) $(OBJECTS) -o $@

.cpp.o:
  echo $< $@
	$(CC) $(CFLAGS) $<

clean:
	del *.o *.exe
