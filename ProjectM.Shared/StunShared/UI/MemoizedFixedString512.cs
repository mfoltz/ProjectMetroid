// Decompiled with JetBrains decompiler
// Type: StunShared.UI.MemoizedFixedString512
// Assembly: ProjectM.Shared, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: CF03A298-FF93-4294-AFD6-565AD334A53C
// Assembly location: C:\Users\mitch\.nuget\packages\vrising.unhollowed.client\0.6.5.57575090\lib\net6.0\ProjectM.Shared.dll

using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using System;
using System.Runtime.InteropServices;
using Unity.Collections;

#nullable disable
namespace StunShared.UI
{
  [Serializable]
  public sealed class MemoizedFixedString512 : Il2CppSystem.ValueType
  {
    private static readonly System.IntPtr NativeFieldInfoPtr__Value;
    private static readonly System.IntPtr NativeFieldInfoPtr__Initialized;
    private static readonly System.IntPtr NativeFieldInfoPtr__Text;
    private static readonly System.IntPtr NativeMethodInfoPtr_GetString_Public_String_FixedString512_0;

    [CallerCount(1)]
    [CachedScanResults(RefRangeStart = 719947, RefRangeEnd = 719948, XrefRangeStart = 719944, XrefRangeEnd = 719947, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe string GetString(FixedString512 val)
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = stackalloc System.IntPtr[1];
      numPtr[0] = (System.IntPtr) &val;
      System.IntPtr exc;
      System.IntPtr il2CppString = IL2CPP.il2cpp_runtime_invoke(MemoizedFixedString512.NativeMethodInfoPtr_GetString_Public_String_FixedString512_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this)), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return IL2CPP.Il2CppStringToManaged(il2CppString);
    }

    static MemoizedFixedString512()
    {
      Il2CppClassPointerStore<MemoizedFixedString512>.NativeClassPtr = IL2CPP.GetIl2CppClass("ProjectM.Shared.dll", "StunShared.UI", nameof (MemoizedFixedString512));
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<MemoizedFixedString512>.NativeClassPtr);
      MemoizedFixedString512.NativeFieldInfoPtr__Value = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MemoizedFixedString512>.NativeClassPtr, nameof (_Value));
      MemoizedFixedString512.NativeFieldInfoPtr__Initialized = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MemoizedFixedString512>.NativeClassPtr, nameof (_Initialized));
      MemoizedFixedString512.NativeFieldInfoPtr__Text = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MemoizedFixedString512>.NativeClassPtr, nameof (_Text));
      MemoizedFixedString512.NativeMethodInfoPtr_GetString_Public_String_FixedString512_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MemoizedFixedString512>.NativeClassPtr, 100663640);
    }

    public MemoizedFixedString512(System.IntPtr pointer)
      : base(pointer)
    {
    }

    public MemoizedFixedString512()
    {
      // ISSUE: cast to a reference type
      // ISSUE: untyped stack allocation
      System.IntPtr data = __untypedstackalloc((System.IntPtr) (uint) IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<MemoizedFixedString512>.NativeClassPtr, (uint&) System.IntPtr.Zero));
      // ISSUE: explicit constructor call
      base.\u002Ector(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<MemoizedFixedString512>.NativeClassPtr, data));
    }

    public unsafe FixedString512 _Value
    {
      get
      {
        return *(FixedString512*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(MemoizedFixedString512.NativeFieldInfoPtr__Value));
      }
      [param: In] set
      {
        *(FixedString512*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(MemoizedFixedString512.NativeFieldInfoPtr__Value)) = value;
      }
    }

    public unsafe bool _Initialized
    {
      get
      {
        return *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(MemoizedFixedString512.NativeFieldInfoPtr__Initialized));
      }
      [param: In] set
      {
        *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(MemoizedFixedString512.NativeFieldInfoPtr__Initialized)) = value;
      }
    }

    public unsafe string _Text
    {
      get
      {
        return IL2CPP.Il2CppStringToManaged(*(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(MemoizedFixedString512.NativeFieldInfoPtr__Text)));
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(MemoizedFixedString512.NativeFieldInfoPtr__Text), IL2CPP.ManagedStringToIl2Cpp(value));
      }
    }
  }
}
