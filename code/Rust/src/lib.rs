fn fact(n : u32) -> u32 {
    return if n == 0 { 1 } else { n * fact(n - 1) }  
}

fn fact_tail(n : u32, acc : u32) -> u32 {
    return if n == 0 { acc } else { fact_tail(n - 1, n * acc) }  
}

#[cfg(test)]
mod tests {
    use super::*;

    #[test]
    fn test_fact() {
        assert_eq!(6, fact(3))
    }

    #[test]
    fn test_fact_tail() {
        assert_eq!(6, fact_tail(3, 1))
    }
}