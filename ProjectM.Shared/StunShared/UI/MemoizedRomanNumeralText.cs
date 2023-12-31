// Decompiled with JetBrains decompiler
// Type: StunShared.UI.MemoizedRomanNumeralText
// Assembly: ProjectM.Shared, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: CF03A298-FF93-4294-AFD6-565AD334A53C
// Assembly location: C:\Users\mitch\.nuget\packages\vrising.unhollowed.client\0.6.5.57575090\lib\net6.0\ProjectM.Shared.dll

using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using System.Runtime.InteropServices;

#nullable disable
namespace StunShared.UI
{
  public sealed class MemoizedRomanNumeralText : Il2CppSystem.ValueType
  {
    private static readonly System.IntPtr NativeFieldInfoPtr__Initialized;
    private static readonly System.IntPtr NativeFieldInfoPtr__IntValue;
    private static readonly System.IntPtr NativeFieldInfoPtr__StringValue;
    private static readonly System.IntPtr NativeMethodInfoPtr_GetString_Public_String_Int32_0;

    [CallerCount(1)]
    [CachedScanResults(RefRangeStart = 719961, RefRangeEnd = 719962, XrefRangeStart = 719961, XrefRangeEnd = 719961, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe string GetString(int val)
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = stackalloc System.IntPtr[1];
      numPtr[0] = (System.IntPtr) &val;
      System.IntPtr exc;
      System.IntPtr il2CppString = IL2CPP.il2cpp_runtime_invoke(MemoizedRomanNumeralText.NativeMethodInfoPtr_GetString_Public_String_Int32_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this)), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return IL2CPP.Il2CppStringToManaged(il2CppString);
    }

    static MemoizedRomanNumeralText()
    {
      Il2CppClassPointerStore<MemoizedRomanNumeralText>.NativeClassPtr = IL2CPP.GetIl2CppClass("ProjectM.Shared.dll", "StunShared.UI", nameof (MemoizedRomanNumeralText));
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<MemoizedRomanNumeralText>.NativeClassPtr);
      MemoizedRomanNumeralText.NativeFieldInfoPtr__Initialized = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MemoizedRomanNumeralText>.NativeClassPtr, nameof (_Initialized));
      MemoizedRomanNumeralText.NativeFieldInfoPtr__IntValue = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MemoizedRomanNumeralText>.NativeClassPtr, nameof (_IntValue));
      MemoizedRomanNumeralText.NativeFieldInfoPtr__StringValue = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MemoizedRomanNumeralText>.NativeClassPtr, nameof (_StringValue));
      MemoizedRomanNumeralText.NativeMethodInfoPtr_GetString_Public_String_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MemoizedRomanNumeralText>.NativeClassPtr, 100663642);
    }

    public MemoizedRomanNumeralText(System.IntPtr pointer)
      : base(pointer)
    {
    }

    public MemoizedRomanNumeralText()
    {
      // ISSUE: cast to a reference type
      // ISSUE: untyped stack allocation
      System.IntPtr data = __untypedstackalloc((System.IntPtr) (uint) IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<MemoizedRomanNumeralText>.NativeClassPtr, (uint&) System.IntPtr.Zero));
      // ISSUE: explicit constructor call
      base.\u002Ector(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<MemoizedRomanNumeralText>.NativeClassPtr, data));
    }

    public unsafe bool _Initialized
    {
      get
      {
        return *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(MemoizedRomanNumeralText.NativeFieldInfoPtr__Initialized));
      }
      [param: In] set
      {
        *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(MemoizedRomanNumeralText.NativeFieldInfoPtr__Initialized)) = value;
      }
    }

    public unsafe int _IntValue
    {
      get
      {
        return *(int*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(MemoizedRomanNumeralText.NativeFieldInfoPtr__IntValue));
      }
      [param: In] set
      {
        *(int*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(MemoizedRomanNumeralText.NativeFieldInfoPtr__IntValue)) = value;
      }
    }

    public unsafe string _StringValue
    {
      get
      {
        return IL2CPP.Il2CppStringToManaged(*(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(MemoizedRomanNumeralText.NativeFieldInfoPtr__StringValue)));
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(MemoizedRomanNumeralText.NativeFieldInfoPtr__StringValue), IL2CPP.ManagedStringToIl2Cpp(value));
      }
    }
  }
}
