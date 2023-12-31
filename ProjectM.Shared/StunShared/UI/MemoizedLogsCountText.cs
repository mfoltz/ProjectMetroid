// Decompiled with JetBrains decompiler
// Type: StunShared.UI.MemoizedLogsCountText
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
  public sealed class MemoizedLogsCountText : Il2CppSystem.ValueType
  {
    private static readonly System.IntPtr NativeFieldInfoPtr__Val1;
    private static readonly System.IntPtr NativeFieldInfoPtr__Val2;
    private static readonly System.IntPtr NativeFieldInfoPtr__Initialized;
    private static readonly System.IntPtr NativeFieldInfoPtr__Text;
    private static readonly System.IntPtr NativeMethodInfoPtr_GetString_Public_String_String_Int32_Int32_0;

    [CallerCount(4)]
    [CachedScanResults(RefRangeStart = 719936, RefRangeEnd = 719940, XrefRangeStart = 719929, XrefRangeEnd = 719936, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe string GetString(string formatString, int val1, int val2)
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = stackalloc System.IntPtr[3];
      numPtr[0] = IL2CPP.ManagedStringToIl2Cpp(formatString);
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &val1;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = (System.IntPtr) &val2;
      System.IntPtr exc;
      System.IntPtr il2CppString = IL2CPP.il2cpp_runtime_invoke(MemoizedLogsCountText.NativeMethodInfoPtr_GetString_Public_String_String_Int32_Int32_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this)), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return IL2CPP.Il2CppStringToManaged(il2CppString);
    }

    static MemoizedLogsCountText()
    {
      Il2CppClassPointerStore<MemoizedLogsCountText>.NativeClassPtr = IL2CPP.GetIl2CppClass("ProjectM.Shared.dll", "StunShared.UI", nameof (MemoizedLogsCountText));
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<MemoizedLogsCountText>.NativeClassPtr);
      MemoizedLogsCountText.NativeFieldInfoPtr__Val1 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MemoizedLogsCountText>.NativeClassPtr, nameof (_Val1));
      MemoizedLogsCountText.NativeFieldInfoPtr__Val2 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MemoizedLogsCountText>.NativeClassPtr, nameof (_Val2));
      MemoizedLogsCountText.NativeFieldInfoPtr__Initialized = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MemoizedLogsCountText>.NativeClassPtr, nameof (_Initialized));
      MemoizedLogsCountText.NativeFieldInfoPtr__Text = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MemoizedLogsCountText>.NativeClassPtr, nameof (_Text));
      MemoizedLogsCountText.NativeMethodInfoPtr_GetString_Public_String_String_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MemoizedLogsCountText>.NativeClassPtr, 100663638);
    }

    public MemoizedLogsCountText(System.IntPtr pointer)
      : base(pointer)
    {
    }

    public MemoizedLogsCountText()
    {
      // ISSUE: cast to a reference type
      // ISSUE: untyped stack allocation
      System.IntPtr data = __untypedstackalloc((System.IntPtr) (uint) IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<MemoizedLogsCountText>.NativeClassPtr, (uint&) System.IntPtr.Zero));
      // ISSUE: explicit constructor call
      base.\u002Ector(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<MemoizedLogsCountText>.NativeClassPtr, data));
    }

    public unsafe int _Val1
    {
      get
      {
        return *(int*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(MemoizedLogsCountText.NativeFieldInfoPtr__Val1));
      }
      [param: In] set
      {
        *(int*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(MemoizedLogsCountText.NativeFieldInfoPtr__Val1)) = value;
      }
    }

    public unsafe int _Val2
    {
      get
      {
        return *(int*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(MemoizedLogsCountText.NativeFieldInfoPtr__Val2));
      }
      [param: In] set
      {
        *(int*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(MemoizedLogsCountText.NativeFieldInfoPtr__Val2)) = value;
      }
    }

    public unsafe bool _Initialized
    {
      get
      {
        return *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(MemoizedLogsCountText.NativeFieldInfoPtr__Initialized));
      }
      [param: In] set
      {
        *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(MemoizedLogsCountText.NativeFieldInfoPtr__Initialized)) = value;
      }
    }

    public unsafe string _Text
    {
      get
      {
        return IL2CPP.Il2CppStringToManaged(*(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(MemoizedLogsCountText.NativeFieldInfoPtr__Text)));
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(MemoizedLogsCountText.NativeFieldInfoPtr__Text), IL2CPP.ManagedStringToIl2Cpp(value));
      }
    }
  }
}
