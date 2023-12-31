// Decompiled with JetBrains decompiler
// Type: StunShared.UI.MemoizedColor
// Assembly: ProjectM.Shared, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: CF03A298-FF93-4294-AFD6-565AD334A53C
// Assembly location: C:\Users\mitch\.nuget\packages\vrising.unhollowed.client\0.6.5.57575090\lib\net6.0\ProjectM.Shared.dll

using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using System;
using System.Runtime.InteropServices;
using UnityEngine;

#nullable disable
namespace StunShared.UI
{
  [Serializable]
  public sealed class MemoizedColor : Il2CppSystem.ValueType
  {
    private static readonly System.IntPtr NativeFieldInfoPtr__Value;
    private static readonly System.IntPtr NativeFieldInfoPtr__Initialized;
    private static readonly System.IntPtr NativeFieldInfoPtr__Text;
    private static readonly System.IntPtr NativeMethodInfoPtr_GetString_Public_String_Color_0;

    [CallerCount(10)]
    [CachedScanResults(RefRangeStart = 719951, RefRangeEnd = 719961, XrefRangeStart = 719948, XrefRangeEnd = 719951, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe string GetString(Color val)
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = stackalloc System.IntPtr[1];
      numPtr[0] = (System.IntPtr) &val;
      System.IntPtr exc;
      System.IntPtr il2CppString = IL2CPP.il2cpp_runtime_invoke(MemoizedColor.NativeMethodInfoPtr_GetString_Public_String_Color_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this)), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return IL2CPP.Il2CppStringToManaged(il2CppString);
    }

    static MemoizedColor()
    {
      Il2CppClassPointerStore<MemoizedColor>.NativeClassPtr = IL2CPP.GetIl2CppClass("ProjectM.Shared.dll", "StunShared.UI", nameof (MemoizedColor));
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<MemoizedColor>.NativeClassPtr);
      MemoizedColor.NativeFieldInfoPtr__Value = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MemoizedColor>.NativeClassPtr, nameof (_Value));
      MemoizedColor.NativeFieldInfoPtr__Initialized = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MemoizedColor>.NativeClassPtr, nameof (_Initialized));
      MemoizedColor.NativeFieldInfoPtr__Text = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MemoizedColor>.NativeClassPtr, nameof (_Text));
      MemoizedColor.NativeMethodInfoPtr_GetString_Public_String_Color_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MemoizedColor>.NativeClassPtr, 100663641);
    }

    public MemoizedColor(System.IntPtr pointer)
      : base(pointer)
    {
    }

    public MemoizedColor()
    {
      // ISSUE: cast to a reference type
      // ISSUE: untyped stack allocation
      System.IntPtr data = __untypedstackalloc((System.IntPtr) (uint) IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<MemoizedColor>.NativeClassPtr, (uint&) System.IntPtr.Zero));
      // ISSUE: explicit constructor call
      base.\u002Ector(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<MemoizedColor>.NativeClassPtr, data));
    }

    public unsafe Color _Value
    {
      get
      {
        return *(Color*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(MemoizedColor.NativeFieldInfoPtr__Value));
      }
      [param: In] set
      {
        *(Color*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(MemoizedColor.NativeFieldInfoPtr__Value)) = value;
      }
    }

    public unsafe bool _Initialized
    {
      get
      {
        return *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(MemoizedColor.NativeFieldInfoPtr__Initialized));
      }
      [param: In] set
      {
        *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(MemoizedColor.NativeFieldInfoPtr__Initialized)) = value;
      }
    }

    public unsafe string _Text
    {
      get
      {
        return IL2CPP.Il2CppStringToManaged(*(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(MemoizedColor.NativeFieldInfoPtr__Text)));
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(MemoizedColor.NativeFieldInfoPtr__Text), IL2CPP.ManagedStringToIl2Cpp(value));
      }
    }
  }
}
