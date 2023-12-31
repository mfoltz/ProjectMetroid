// Decompiled with JetBrains decompiler
// Type: StunShared.UI.MemoizedIntegerText
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
  public sealed class MemoizedIntegerText : Il2CppSystem.ValueType
  {
    private static readonly System.IntPtr NativeFieldInfoPtr__Initialized;
    private static readonly System.IntPtr NativeFieldInfoPtr__LastNumber;
    private static readonly System.IntPtr NativeFieldInfoPtr__Text;
    private static readonly System.IntPtr NativeMethodInfoPtr_get_Number_Public_get_Int32_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_GetString_Public_String_Int32_String_0;

    public unsafe int Number
    {
      [CallerCount(33), CachedScanResults(RefRangeStart = 107697, RefRangeEnd = 107730, XrefRangeStart = 107697, XrefRangeEnd = 107730, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] get
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        System.IntPtr* numPtr = (System.IntPtr*) null;
        System.IntPtr exc;
        System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(MemoizedIntegerText.NativeMethodInfoPtr_get_Number_Public_get_Int32_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this)), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
        return *(int*) IL2CPP.il2cpp_object_unbox(num);
      }
    }

    [CallerCount(7)]
    [CachedScanResults(RefRangeStart = 719913, RefRangeEnd = 719920, XrefRangeStart = 719905, XrefRangeEnd = 719913, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe string GetString(int number, string formatString = null)
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = stackalloc System.IntPtr[2];
      numPtr[0] = (System.IntPtr) &number;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = IL2CPP.ManagedStringToIl2Cpp(formatString);
      System.IntPtr exc;
      System.IntPtr il2CppString = IL2CPP.il2cpp_runtime_invoke(MemoizedIntegerText.NativeMethodInfoPtr_GetString_Public_String_Int32_String_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this)), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return IL2CPP.Il2CppStringToManaged(il2CppString);
    }

    static MemoizedIntegerText()
    {
      Il2CppClassPointerStore<MemoizedIntegerText>.NativeClassPtr = IL2CPP.GetIl2CppClass("ProjectM.Shared.dll", "StunShared.UI", nameof (MemoizedIntegerText));
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<MemoizedIntegerText>.NativeClassPtr);
      MemoizedIntegerText.NativeFieldInfoPtr__Initialized = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MemoizedIntegerText>.NativeClassPtr, nameof (_Initialized));
      MemoizedIntegerText.NativeFieldInfoPtr__LastNumber = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MemoizedIntegerText>.NativeClassPtr, nameof (_LastNumber));
      MemoizedIntegerText.NativeFieldInfoPtr__Text = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MemoizedIntegerText>.NativeClassPtr, nameof (_Text));
      MemoizedIntegerText.NativeMethodInfoPtr_get_Number_Public_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MemoizedIntegerText>.NativeClassPtr, 100663633);
      MemoizedIntegerText.NativeMethodInfoPtr_GetString_Public_String_Int32_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MemoizedIntegerText>.NativeClassPtr, 100663634);
    }

    public MemoizedIntegerText(System.IntPtr pointer)
      : base(pointer)
    {
    }

    public MemoizedIntegerText()
    {
      // ISSUE: cast to a reference type
      // ISSUE: untyped stack allocation
      System.IntPtr data = __untypedstackalloc((System.IntPtr) (uint) IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<MemoizedIntegerText>.NativeClassPtr, (uint&) System.IntPtr.Zero));
      // ISSUE: explicit constructor call
      base.\u002Ector(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<MemoizedIntegerText>.NativeClassPtr, data));
    }

    public unsafe bool _Initialized
    {
      get
      {
        return *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(MemoizedIntegerText.NativeFieldInfoPtr__Initialized));
      }
      [param: In] set
      {
        *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(MemoizedIntegerText.NativeFieldInfoPtr__Initialized)) = value;
      }
    }

    public unsafe int _LastNumber
    {
      get
      {
        return *(int*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(MemoizedIntegerText.NativeFieldInfoPtr__LastNumber));
      }
      [param: In] set
      {
        *(int*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(MemoizedIntegerText.NativeFieldInfoPtr__LastNumber)) = value;
      }
    }

    public unsafe string _Text
    {
      get
      {
        return IL2CPP.Il2CppStringToManaged(*(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(MemoizedIntegerText.NativeFieldInfoPtr__Text)));
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(MemoizedIntegerText.NativeFieldInfoPtr__Text), IL2CPP.ManagedStringToIl2Cpp(value));
      }
    }
  }
}
