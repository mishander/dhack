# Install script for directory: C:/Liza_stuff/dhack/leptonica/src

# Set the install prefix
if(NOT DEFINED CMAKE_INSTALL_PREFIX)
  set(CMAKE_INSTALL_PREFIX "C:/Liza_stuff/dhack/build/x64")
endif()
string(REGEX REPLACE "/$" "" CMAKE_INSTALL_PREFIX "${CMAKE_INSTALL_PREFIX}")

# Set the install configuration name.
if(NOT DEFINED CMAKE_INSTALL_CONFIG_NAME)
  if(BUILD_TYPE)
    string(REGEX REPLACE "^[^A-Za-z0-9_]+" ""
           CMAKE_INSTALL_CONFIG_NAME "${BUILD_TYPE}")
  else()
    set(CMAKE_INSTALL_CONFIG_NAME "Release")
  endif()
  message(STATUS "Install configuration: \"${CMAKE_INSTALL_CONFIG_NAME}\"")
endif()

# Set the component getting installed.
if(NOT CMAKE_INSTALL_COMPONENT)
  if(COMPONENT)
    message(STATUS "Install component: \"${COMPONENT}\"")
    set(CMAKE_INSTALL_COMPONENT "${COMPONENT}")
  else()
    set(CMAKE_INSTALL_COMPONENT)
  endif()
endif()

# Is this installation the result of a crosscompile?
if(NOT DEFINED CMAKE_CROSSCOMPILING)
  set(CMAKE_CROSSCOMPILING "FALSE")
endif()

if("x${CMAKE_INSTALL_COMPONENT}x" STREQUAL "xUnspecifiedx" OR NOT CMAKE_INSTALL_COMPONENT)
  if("${CMAKE_INSTALL_CONFIG_NAME}" MATCHES "^([Dd][Ee][Bb][Uu][Gg])$")
    file(INSTALL DESTINATION "${CMAKE_INSTALL_PREFIX}/lib" TYPE STATIC_LIBRARY FILES "C:/Liza_stuff/dhack/leptonica/vs16-x64/src/Debug/leptonica-1.80.0d.lib")
  elseif("${CMAKE_INSTALL_CONFIG_NAME}" MATCHES "^([Rr][Ee][Ll][Ee][Aa][Ss][Ee])$")
    file(INSTALL DESTINATION "${CMAKE_INSTALL_PREFIX}/lib" TYPE STATIC_LIBRARY FILES "C:/Liza_stuff/dhack/leptonica/vs16-x64/src/Release/leptonica-1.80.0.lib")
  elseif("${CMAKE_INSTALL_CONFIG_NAME}" MATCHES "^([Mm][Ii][Nn][Ss][Ii][Zz][Ee][Rr][Ee][Ll])$")
    file(INSTALL DESTINATION "${CMAKE_INSTALL_PREFIX}/lib" TYPE STATIC_LIBRARY FILES "C:/Liza_stuff/dhack/leptonica/vs16-x64/src/MinSizeRel/leptonica-1.80.0.lib")
  elseif("${CMAKE_INSTALL_CONFIG_NAME}" MATCHES "^([Rr][Ee][Ll][Ww][Ii][Tt][Hh][Dd][Ee][Bb][Ii][Nn][Ff][Oo])$")
    file(INSTALL DESTINATION "${CMAKE_INSTALL_PREFIX}/lib" TYPE STATIC_LIBRARY FILES "C:/Liza_stuff/dhack/leptonica/vs16-x64/src/RelWithDebInfo/leptonica-1.80.0.lib")
  endif()
endif()

if("x${CMAKE_INSTALL_COMPONENT}x" STREQUAL "xUnspecifiedx" OR NOT CMAKE_INSTALL_COMPONENT)
  if(EXISTS "$ENV{DESTDIR}${CMAKE_INSTALL_PREFIX}/cmake/LeptonicaTargets.cmake")
    file(DIFFERENT EXPORT_FILE_CHANGED FILES
         "$ENV{DESTDIR}${CMAKE_INSTALL_PREFIX}/cmake/LeptonicaTargets.cmake"
         "C:/Liza_stuff/dhack/leptonica/vs16-x64/src/CMakeFiles/Export/cmake/LeptonicaTargets.cmake")
    if(EXPORT_FILE_CHANGED)
      file(GLOB OLD_CONFIG_FILES "$ENV{DESTDIR}${CMAKE_INSTALL_PREFIX}/cmake/LeptonicaTargets-*.cmake")
      if(OLD_CONFIG_FILES)
        message(STATUS "Old export file \"$ENV{DESTDIR}${CMAKE_INSTALL_PREFIX}/cmake/LeptonicaTargets.cmake\" will be replaced.  Removing files [${OLD_CONFIG_FILES}].")
        file(REMOVE ${OLD_CONFIG_FILES})
      endif()
    endif()
  endif()
  file(INSTALL DESTINATION "${CMAKE_INSTALL_PREFIX}/cmake" TYPE FILE FILES "C:/Liza_stuff/dhack/leptonica/vs16-x64/src/CMakeFiles/Export/cmake/LeptonicaTargets.cmake")
  if("${CMAKE_INSTALL_CONFIG_NAME}" MATCHES "^([Dd][Ee][Bb][Uu][Gg])$")
    file(INSTALL DESTINATION "${CMAKE_INSTALL_PREFIX}/cmake" TYPE FILE FILES "C:/Liza_stuff/dhack/leptonica/vs16-x64/src/CMakeFiles/Export/cmake/LeptonicaTargets-debug.cmake")
  endif()
  if("${CMAKE_INSTALL_CONFIG_NAME}" MATCHES "^([Mm][Ii][Nn][Ss][Ii][Zz][Ee][Rr][Ee][Ll])$")
    file(INSTALL DESTINATION "${CMAKE_INSTALL_PREFIX}/cmake" TYPE FILE FILES "C:/Liza_stuff/dhack/leptonica/vs16-x64/src/CMakeFiles/Export/cmake/LeptonicaTargets-minsizerel.cmake")
  endif()
  if("${CMAKE_INSTALL_CONFIG_NAME}" MATCHES "^([Rr][Ee][Ll][Ww][Ii][Tt][Hh][Dd][Ee][Bb][Ii][Nn][Ff][Oo])$")
    file(INSTALL DESTINATION "${CMAKE_INSTALL_PREFIX}/cmake" TYPE FILE FILES "C:/Liza_stuff/dhack/leptonica/vs16-x64/src/CMakeFiles/Export/cmake/LeptonicaTargets-relwithdebinfo.cmake")
  endif()
  if("${CMAKE_INSTALL_CONFIG_NAME}" MATCHES "^([Rr][Ee][Ll][Ee][Aa][Ss][Ee])$")
    file(INSTALL DESTINATION "${CMAKE_INSTALL_PREFIX}/cmake" TYPE FILE FILES "C:/Liza_stuff/dhack/leptonica/vs16-x64/src/CMakeFiles/Export/cmake/LeptonicaTargets-release.cmake")
  endif()
endif()

if("x${CMAKE_INSTALL_COMPONENT}x" STREQUAL "xUnspecifiedx" OR NOT CMAKE_INSTALL_COMPONENT)
  file(INSTALL DESTINATION "${CMAKE_INSTALL_PREFIX}/include/leptonica" TYPE FILE FILES
    "C:/Liza_stuff/dhack/leptonica/src/allheaders.h"
    "C:/Liza_stuff/dhack/leptonica/src/alltypes.h"
    "C:/Liza_stuff/dhack/leptonica/src/array.h"
    "C:/Liza_stuff/dhack/leptonica/src/arrayaccess.h"
    "C:/Liza_stuff/dhack/leptonica/src/bbuffer.h"
    "C:/Liza_stuff/dhack/leptonica/src/bilateral.h"
    "C:/Liza_stuff/dhack/leptonica/src/bmf.h"
    "C:/Liza_stuff/dhack/leptonica/src/bmfdata.h"
    "C:/Liza_stuff/dhack/leptonica/src/bmp.h"
    "C:/Liza_stuff/dhack/leptonica/src/ccbord.h"
    "C:/Liza_stuff/dhack/leptonica/src/colorfill.h"
    "C:/Liza_stuff/dhack/leptonica/src/dewarp.h"
    "C:/Liza_stuff/dhack/leptonica/src/environ.h"
    "C:/Liza_stuff/dhack/leptonica/src/gplot.h"
    "C:/Liza_stuff/dhack/leptonica/src/heap.h"
    "C:/Liza_stuff/dhack/leptonica/src/imageio.h"
    "C:/Liza_stuff/dhack/leptonica/src/jbclass.h"
    "C:/Liza_stuff/dhack/leptonica/src/leptwin.h"
    "C:/Liza_stuff/dhack/leptonica/src/list.h"
    "C:/Liza_stuff/dhack/leptonica/src/morph.h"
    "C:/Liza_stuff/dhack/leptonica/src/pix.h"
    "C:/Liza_stuff/dhack/leptonica/src/ptra.h"
    "C:/Liza_stuff/dhack/leptonica/src/queue.h"
    "C:/Liza_stuff/dhack/leptonica/src/rbtree.h"
    "C:/Liza_stuff/dhack/leptonica/src/readbarcode.h"
    "C:/Liza_stuff/dhack/leptonica/src/recog.h"
    "C:/Liza_stuff/dhack/leptonica/src/regutils.h"
    "C:/Liza_stuff/dhack/leptonica/src/stack.h"
    "C:/Liza_stuff/dhack/leptonica/src/stringcode.h"
    "C:/Liza_stuff/dhack/leptonica/src/sudoku.h"
    "C:/Liza_stuff/dhack/leptonica/src/watershed.h"
    "C:/Liza_stuff/dhack/leptonica/vs16-x64/src/endianness.h"
    )
endif()

