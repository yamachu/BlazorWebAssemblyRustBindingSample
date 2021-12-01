#include <stdarg.h>
#include <stdbool.h>
#include <stdint.h>

#ifdef __cplusplus
extern "C" {
#endif // __cplusplus

uint8_t array_allocation(uint8_t **out_arr);

void array_deallocation(uint8_t **out_arr);

#ifdef __cplusplus
} // extern "C"
#endif // __cplusplus
