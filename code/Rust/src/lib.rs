use crate::Thunk::{Call, Done};

fn fact(n: u32) -> u32 {
    return if n == 0 { 1 } else { n * fact(n - 1) };
}

enum Thunk<T> {
    Done(T),
    Call(Box<dyn FnOnce() -> Thunk<T>>),
}

impl <T> Thunk<T> {
    fn trampoline(self) -> T {
        let mut current = self;
        loop {
            match current {
                Call(f) => current = f(),
                Done(v) => return v,
            }
        }
    }
}

fn fact_tram(n: u32, acc: u32) -> Thunk<u32> {
    return if n == 0 { Done(acc) } else { Call(Box::new(move || fact_tram(n - 1, n * acc))) };
}

fn fact_tail(n: u32, acc: u32) -> u32 {
    return if n == 0 { acc } else { fact_tail(n - 1, n * acc) };
}

#[cfg(test)]
mod tests {
    use super::*;

    #[test]
    fn test_fact() {
        assert_eq!(6, fact(3))
    }

    #[test]
    fn test_fact_tramp() {
        assert_eq!(6, fact_tram(3, 1).trampoline())
    }

    #[test]
    fn test_fact_tail() {
        assert_eq!(6, fact_tail(3, 1))
    }
}