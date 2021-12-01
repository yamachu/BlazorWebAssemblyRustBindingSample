use rand::prelude::*;

#[no_mangle]
pub unsafe extern "C" fn array_allocation(
    out_arr: *mut *mut u8,
) -> u8 {
    let array_length: u8 = random();
    let mut seq: Vec<u8> = (0..array_length).collect();

    *out_arr = seq.as_mut_ptr();

    array_length
}

#[no_mangle]
pub unsafe extern "C" fn array_deallocation(
    out_arr: *mut *mut u8,
) {
    std::mem::forget(*out_arr)
}

