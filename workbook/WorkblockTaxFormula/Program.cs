// See https://aka.ms/new-console-template for more information

/// <summary>
/// Caluculate the total amount of money in this pretend tax bracket
/// </summary>
/// 


// Amount of money will get taxed differently.
// if you are below $10.00, 10% tax.
// Over $10.00 and under $15.00 <-- this amount gets taxed 15%

// What happens when I have $11.50?

// Tax the first $10.00 at 10%
// THEN tax the REMAINDER from that WITHIN the range at 15%
// $1.50 gets taxed at 15%

// What do I need to calculate at the end?
// Total == SUM

// Calculate seperately and add together.
const decimal GROSS_UNDER_TEN = 10.00m;
const decimal GROSS_FIFTEEN = 15.00m;
const decimal GROSS_THIRTY = 30.00m;

const decimal TAX_RATE_TIER_1 = 0.1m;
const decimal TAX_RATE_TIER_2 = 0.15m;
const decimal TAX_RATE_TIER_3 = 0.3m;


decimal grossEarnings = 14.00m;
decimal taxSum = 0.00m;

if (grossEarnings <= GROSS_UNDER_TEN)
{
    taxSum += grossEarnings * TAX_RATE_TIER_1;
}

else if (grossEarnings > GROSS_UNDER_TEN && grossEarnings < GROSS_FIFTEEN)
{
    // If I'm above $10.00, I HAVE TEN DOLLARS
    taxSum += 10.00m * TAX_RATE_TIER_1;
    taxSum += (grossEarnings - 10.00m) * TAX_RATE_TIER_2;
}
else if (grossEarnings > GROSS_FIFTEEN && grossEarnings < GROSS_THIRTY)
{
    // If I'm above $15.00, I HAVE FIFTEEN DOLLARS
    taxSum += 10.00m * TAX_RATE_TIER_1;
    taxSum += 5.00m * TAX_RATE_TIER_2;
    taxSum += (grossEarnings - 15.00m) * TAX_RATE_TIER_3;
}