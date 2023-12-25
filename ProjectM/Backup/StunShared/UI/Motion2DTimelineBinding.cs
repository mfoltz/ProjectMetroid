// Decompiled with JetBrains decompiler
// Type: StunShared.UI.Motion2DTimelineBinding
// Assembly: ProjectM, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 83E42B70-D81B-4F1F-9FB5-6B5ABD5FF9FC
// Assembly location: C:\Users\mitch\.nuget\packages\vrising.unhollowed.client\0.6.5.57575090\lib\net6.0\ProjectM.dll

using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using System;
using System.Runtime.InteropServices;

#nullable disable
namespace StunShared.UI
{
  [Serializable]
  public sealed class Motion2DTimelineBinding : Il2CppSystem.ValueType
  {
    private static readonly System.IntPtr NativeFieldInfoPtr_ClipGUID;
    private static readonly System.IntPtr NativeFieldInfoPtr_Start;
    private static readonly System.IntPtr NativeFieldInfoPtr_End;
    private static readonly System.IntPtr NativeFieldInfoPtr_Current;
    private static readonly System.IntPtr NativeFieldInfoPtr_Mask;

    static Motion2DTimelineBinding()
    {
      Il2CppClassPointerStore<Motion2DTimelineBinding>.NativeClassPtr = IL2CPP.GetIl2CppClass("ProjectM.dll", "StunShared.UI", nameof (Motion2DTimelineBinding));
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Motion2DTimelineBinding>.NativeClassPtr);
      Motion2DTimelineBinding.NativeFieldInfoPtr_ClipGUID = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Motion2DTimelineBinding>.NativeClassPtr, nameof (ClipGUID));
      Motion2DTimelineBinding.NativeFieldInfoPtr_Start = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Motion2DTimelineBinding>.NativeClassPtr, nameof (Start));
      Motion2DTimelineBinding.NativeFieldInfoPtr_End = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Motion2DTimelineBinding>.NativeClassPtr, nameof (End));
      Motion2DTimelineBinding.NativeFieldInfoPtr_Current = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Motion2DTimelineBinding>.NativeClassPtr, nameof (Current));
      Motion2DTimelineBinding.NativeFieldInfoPtr_Mask = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Motion2DTimelineBinding>.NativeClassPtr, nameof (Mask));
    }

    public Motion2DTimelineBinding(System.IntPtr pointer)
      : base(pointer)
    {
    }

    public Motion2DTimelineBinding()
    {
      // ISSUE: cast to a reference type
      // ISSUE: untyped stack allocation
      System.IntPtr data = __untypedstackalloc((System.IntPtr) (uint) IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<Motion2DTimelineBinding>.NativeClassPtr, (uint&) System.IntPtr.Zero));
      // ISSUE: explicit constructor call
      base.\u002Ector(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<Motion2DTimelineBinding>.NativeClassPtr, data));
    }

    public unsafe Il2CppStructArray<byte> ClipGUID
    {
      get
      {
        System.IntPtr nativeObject = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(Motion2DTimelineBinding.NativeFieldInfoPtr_ClipGUID));
        return nativeObject == System.IntPtr.Zero ? (Il2CppStructArray<byte>) null : new Il2CppStructArray<byte>(nativeObject);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(Motion2DTimelineBinding.NativeFieldInfoPtr_ClipGUID), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe Motion2DValues Start
    {
      get
      {
        return *(Motion2DValues*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(Motion2DTimelineBinding.NativeFieldInfoPtr_Start));
      }
      [param: In] set
      {
        *(Motion2DValues*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(Motion2DTimelineBinding.NativeFieldInfoPtr_Start)) = value;
      }
    }

    public unsafe Motion2DValues End
    {
      get
      {
        return *(Motion2DValues*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(Motion2DTimelineBinding.NativeFieldInfoPtr_End));
      }
      [param: In] set
      {
        *(Motion2DValues*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(Motion2DTimelineBinding.NativeFieldInfoPtr_End)) = value;
      }
    }

    public unsafe Motion2DValues Current
    {
      get
      {
        return *(Motion2DValues*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(Motion2DTimelineBinding.NativeFieldInfoPtr_Current));
      }
      [param: In] set
      {
        *(Motion2DValues*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(Motion2DTimelineBinding.NativeFieldInfoPtr_Current)) = value;
      }
    }

    public unsafe Motion2DMask Mask
    {
      get
      {
        return *(Motion2DMask*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(Motion2DTimelineBinding.NativeFieldInfoPtr_Mask));
      }
      [param: In] set
      {
        *(Motion2DMask*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(Motion2DTimelineBinding.NativeFieldInfoPtr_Mask)) = value;
      }
    }
  }
}
