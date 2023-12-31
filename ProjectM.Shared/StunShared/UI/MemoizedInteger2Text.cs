// Decompiled with JetBrains decompiler
// Type: StunShared.UI.MemoizedInteger2Text
// Assembly: ProjectM.Shared, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: CF03A298-FF93-4294-AFD6-565AD334A53C
// Assembly location: C:\Users\mitch\.nuget\packages\vrising.unhollowed.client\0.6.5.57575090\lib\net6.0\ProjectM.Shared.dll

using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using System;
using System.Runtime.InteropServices;

#nullable disable
namespace StunShared.UI
{
  [Serializable]
  public sealed class MemoizedInteger2Text : Il2CppSystem.ValueType
  {
    private static readonly System.IntPtr NativeFieldInfoPtr__Initialized;
    private static readonly System.IntPtr NativeFieldInfoPtr__IntA;
    private static readonly System.IntPtr NativeFieldInfoPtr__IntB;
    private static readonly System.IntPtr NativeFieldInfoPtr__Text;
    private static readonly System.IntPtr NativeMethodInfoPtr_get_NumberA_Public_get_Int32_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_get_NumberB_Public_get_Int32_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_GetString_Public_String_Int32_Int32_String_0;

    public unsafe int NumberA
    {
      [CallerCount(33), CachedScanResults(RefRangeStart = 107697, RefRangeEnd = 107730, XrefRangeStart = 107697, XrefRangeEnd = 107730, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] get
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        System.IntPtr* numPtr = (System.IntPtr*) null;
        System.IntPtr exc;
        System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(MemoizedInteger2Text.NativeMethodInfoPtr_get_NumberA_Public_get_Int32_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this)), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
        return *(int*) IL2CPP.il2cpp_object_unbox(num);
      }
    }

    public unsafe int NumberB
    {
      [CallerCount(33), CachedScanResults(RefRangeStart = 40848, RefRangeEnd = 40881, XrefRangeStart = 40848, XrefRangeEnd = 40881, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] get
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        System.IntPtr* numPtr = (System.IntPtr*) null;
        System.IntPtr exc;
        System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(MemoizedInteger2Text.NativeMethodInfoPtr_get_NumberB_Public_get_Int32_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this)), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
        return *(int*) IL2CPP.il2cpp_object_unbox(num);
      }
    }

    [CallerCount(2)]
    [CachedScanResults(RefRangeStart = 719927, RefRangeEnd = 719929, XrefRangeStart = 719920, XrefRangeEnd = 719927, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe string GetString(int numberA, int numberB, string formatString)
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = stackalloc System.IntPtr[3];
      numPtr[0] = (System.IntPtr) &numberA;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &numberB;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = IL2CPP.ManagedStringToIl2Cpp(formatString);
      System.IntPtr exc;
      System.IntPtr il2CppString = IL2CPP.il2cpp_runtime_invoke(MemoizedInteger2Text.NativeMethodInfoPtr_GetString_Public_String_Int32_Int32_String_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this)), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return IL2CPP.Il2CppStringToManaged(il2CppString);
    }

    static MemoizedInteger2Text()
    {
      Il2CppClassPointerStore<MemoizedInteger2Text>.NativeClassPtr = IL2CPP.GetIl2CppClass("ProjectM.Shared.dll", "StunShared.UI", nameof (MemoizedInteger2Text));
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<MemoizedInteger2Text>.NativeClassPtr);
      MemoizedInteger2Text.NativeFieldInfoPtr__Initialized = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MemoizedInteger2Text>.NativeClassPtr, nameof (_Initialized));
      MemoizedInteger2Text.NativeFieldInfoPtr__IntA = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MemoizedInteger2Text>.NativeClassPtr, nameof (_IntA));
      MemoizedInteger2Text.NativeFieldInfoPtr__IntB = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MemoizedInteger2Text>.NativeClassPtr, nameof (_IntB));
      MemoizedInteger2Text.NativeFieldInfoPtr__Text = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MemoizedInteger2Text>.NativeClassPtr, nameof (_Text));
      MemoizedInteger2Text.NativeMethodInfoPtr_get_NumberA_Public_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MemoizedInteger2Text>.NativeClassPtr, 100663635);
      MemoizedInteger2Text.NativeMethodInfoPtr_get_NumberB_Public_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MemoizedInteger2Text>.NativeClassPtr, 100663636);
      MemoizedInteger2Text.NativeMethodInfoPtr_GetString_Public_String_Int32_Int32_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MemoizedInteger2Text>.NativeClassPtr, 100663637);
    }

    public MemoizedInteger2Text(System.IntPtr pointer)
      : base(pointer)
    {
    }

    public MemoizedInteger2Text()
    {
      // ISSUE: cast to a reference type
      // ISSUE: untyped stack allocation
      System.IntPtr data = __untypedstackalloc((System.IntPtr) (uint) IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<MemoizedInteger2Text>.NativeClassPtr, (uint&) System.IntPtr.Zero));
      // ISSUE: explicit constructor call
      base.\u002Ector(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<MemoizedInteger2Text>.NativeClassPtr, data));
    }

    public unsafe bool _Initialized
    {
      get
      {
        return *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(MemoizedInteger2Text.NativeFieldInfoPtr__Initialized));
      }
      [param: In] set
      {
        *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(MemoizedInteger2Text.NativeFieldInfoPtr__Initialized)) = value;
      }
    }

    public unsafe int _IntA
    {
      get
      {
        return *(int*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(MemoizedInteger2Text.NativeFieldInfoPtr__IntA));
      }
      [param: In] set
      {
        *(int*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(MemoizedInteger2Text.NativeFieldInfoPtr__IntA)) = value;
      }
    }

    public unsafe int _IntB
    {
      get
      {
        return *(int*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(MemoizedInteger2Text.NativeFieldInfoPtr__IntB));
      }
      [param: In] set
      {
        *(int*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(MemoizedInteger2Text.NativeFieldInfoPtr__IntB)) = value;
      }
    }

    public unsafe string _Text
    {
      get
      {
        return IL2CPP.Il2CppStringToManaged(*(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(MemoizedInteger2Text.NativeFieldInfoPtr__Text)));
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(MemoizedInteger2Text.NativeFieldInfoPtr__Text), IL2CPP.ManagedStringToIl2Cpp(value));
      }
    }
  }
}
