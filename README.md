# lexical-analyzer-with-symbol-table
6.1 Programs
A C# program consists of one or more source files, known formally as compilation units (§13.2). Although a compilation unit might have a one-to-one correspondence with a file in a file system, such correspondence is not required.

Conceptually speaking, a program is compiled using three steps:

Transformation, which converts a file from a particular character repertoire and encoding scheme into a sequence of Unicode characters.
Lexical analysis, which translates a stream of Unicode input characters into a stream of tokens.
Syntactic analysis, which translates the stream of tokens into executable code.
Conforming implementations shall accept Unicode compilation units encoded with the UTF-8 encoding form (as defined by the Unicode standard), and transform them into a sequence of Unicode characters. Implementations can choose to accept and transform additional character encoding schemes (such as UTF-16, UTF-32, or non-Unicode character mappings).

Note: The handling of the Unicode NULL character (U+0000) is implementation-specific. It is strongly recommended that developers avoid using this character in their source code, for the sake of both portability and readability. When the character is required within a character or string literal, the escape sequences \0 or \u0000 may be used instead. end note

Note: It is beyond the scope of this standard to define how a file using a character representation other than Unicode might be transformed into a sequence of Unicode characters. During such transformation, however, it is recommended that the usual line-separating character (or sequence) in the other character set be translated to the two-character sequence consisting of the Unicode carriage-return character (U+000D) followed by Unicode line-feed character (U+000A). For the most part this transformation will have no visible effects; however, it will affect the interpretation of verbatim string literal tokens (§6.4.5.6). The purpose of this recommendation is to allow a verbatim string literal to produce the same character sequence when its compilation unit is moved between systems that support differing non-Unicode character sets, in particular, those using differing character sequences for line-separation. end note

6.2 Grammars
6.2.1 General
This specification presents the syntax of the C# programming language using two grammars. The lexical grammar (§6.2.3) defines how Unicode characters are combined to form line terminators, white space, comments, tokens, and pre-processing directives. The syntactic grammar (§6.2.4) defines how the tokens resulting from the lexical grammar are combined to form C# programs.

All terminal characters are to be understood as the appropriate Unicode character from the range U+0020 to U+007F, as opposed to any similar-looking characters from other Unicode character ranges.

6.2.2 Grammar notation
The lexical and syntactic grammars are presented in the ANTLR grammar tool’s Extended Backus-Naur form.

While the ANTLR notation is used, this Standard does not present a complete ANTLR-ready “reference grammar” for C#; writing a lexer and parser, either by hand or using a tool such as ANTLR, is outside the scope of a language specification. With that qualification, this Standard attempts to minimize the gap between the specified grammar and that required to build a lexer and parser in ANTLR.

ANTLR distinguishes between lexical and syntactic, termed parser by ANTLR, grammars in its notation by starting lexical rules with an uppercase letter and parser rules with a lowercase letter.

Note: The C# lexical grammar (§6.2.3) and syntactic grammar (§6.2.4) are not in exact correspondence with the ANTLR division into lexical and parser grammers. This small mismatch means that some ANTLR parser rules are used when specifying the C# lexical grammar. end note

6.2.3 Lexical grammar
The lexical grammar of C# is presented in §6.3, §6.4, and §6.5. The terminal symbols of the lexical grammar are the characters of the Unicode character set, and the lexical grammar specifies how characters are combined to form tokens (§6.4), white space (§6.3.4), comments (§6.3.3), and pre-processing directives (§6.5).

Many of the terminal symbols of the syntactic grammar are not defined explicitly as tokens in the lexical grammar. Rather, advantage is taken of the ANTLR behavior that literal strings in the grammar are extracted as implicit lexical tokens; this allows keywords, operators, etc. to be represented in the grammar by their literal representation rather than a token name.

Every compilation unit in a C# program shall conform to the input production of the lexical grammar (§6.3.1).

6.2.4 Syntactic grammar
The syntactic grammar of C# is presented in the clauses, subclauses, and annexes that follow this subclause. The terminal symbols of the syntactic grammar are the tokens defined explicitly by the lexical grammar and implicitly by literal strings in the grammar itself (§6.2.3). The syntactic grammar specifies how tokens are combined to form C# programs.

Every compilation unit in a C# program shall conform to the compilation_unit production (§13.2) of the syntactic grammar.

