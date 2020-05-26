#----------------------------------------------------------------
# Generated CMake target import file for configuration "Debug".
#----------------------------------------------------------------

# Commands may need to know the format version.
set(CMAKE_IMPORT_FILE_VERSION 1)

# Import target "leptonica" for configuration "Debug"
set_property(TARGET leptonica APPEND PROPERTY IMPORTED_CONFIGURATIONS DEBUG)
set_target_properties(leptonica PROPERTIES
  IMPORTED_LINK_INTERFACE_LANGUAGES_DEBUG "CXX"
  IMPORTED_LINK_INTERFACE_LIBRARIES_DEBUG "C:/vcpkg/installed/x64-windows-static/debug/lib/gif.lib;C:/vcpkg/installed/x64-windows-static/debug/lib/jpegd.lib;C:/vcpkg/installed/x64-windows-static/debug/lib/libpng16d.lib;C:/vcpkg/installed/x64-windows-static/debug/lib/zlibd.lib;C:/vcpkg/installed/x64-windows-static/debug/lib/tiffd.lib;C:/vcpkg/installed/x64-windows-static/debug/lib/lzmad.lib;C:/vcpkg/installed/x64-windows-static/debug/lib/jpegd.lib;C:/vcpkg/installed/x64-windows-static/debug/lib/zlibd.lib;C:/vcpkg/installed/x64-windows-static/debug/lib/zlibd.lib"
  IMPORTED_LOCATION_DEBUG "${_IMPORT_PREFIX}/lib/leptonica-1.80.0d.lib"
  )

list(APPEND _IMPORT_CHECK_TARGETS leptonica )
list(APPEND _IMPORT_CHECK_FILES_FOR_leptonica "${_IMPORT_PREFIX}/lib/leptonica-1.80.0d.lib" )

# Commands beyond this point should not need to know the version.
set(CMAKE_IMPORT_FILE_VERSION)
