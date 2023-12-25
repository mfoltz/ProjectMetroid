// Decompiled with JetBrains decompiler
// Type: StunShared.UI.Motion2DClip
// Assembly: ProjectM, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 83E42B70-D81B-4F1F-9FB5-6B5ABD5FF9FC
// Assembly location: C:\Users\mitch\.nuget\packages\vrising.unhollowed.client\0.6.5.57575090\lib\net6.0\ProjectM.dll

using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using System;
using System.Runtime.InteropServices;

#nullable disable
namespace StunShared.UI
{
  [Serializable]
  public class Motion2DClip : Il2CppSystem.Object
  {
    private static readonly System.IntPtr NativeFieldInfoPtr_GUID;
    private static readonly System.IntPtr NativeFieldInfoPtr_Name;
    private static readonly System.IntPtr NativeFieldInfoPtr_Start;
    private static readonly System.IntPtr NativeFieldInfoPtr_Duration;
    private static readonly System.IntPtr NativeFieldInfoPtr_Curve;
    private static readonly System.IntPtr NativeFieldInfoPtr_EasingCurve;
    private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_Il2CppStructArray_1_Byte_0;

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 923388, XrefRangeEnd = 923390, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe Motion2DClip(Il2CppStructArray<byte> guid)
      : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Motion2DClip>.NativeClassPtr))
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[1];
      numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) guid);
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(Motion2DClip.NativeMethodInfoPtr__ctor_Public_Void_Il2CppStructArray_1_Byte_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    static Motion2DClip()
    {
      Il2CppClassPointerStore<Motion2DClip>.NativeClassPtr = IL2CPP.GetIl2CppClass("ProjectM.dll", "StunShared.UI", nameof (Motion2DClip));
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Motion2DClip>.NativeClassPtr);
      Motion2DClip.NativeFieldInfoPtr_GUID = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Motion2DClip>.NativeClassPtr, nameof (GUID));
      Motion2DClip.NativeFieldInfoPtr_Name = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Motion2DClip>.NativeClassPtr, nameof (Name));
      Motion2DClip.NativeFieldInfoPtr_Start = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Motion2DClip>.NativeClassPtr, nameof (Start));
      Motion2DClip.NativeFieldInfoPtr_Duration = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Motion2DClip>.NativeClassPtr, nameof (Duration));
      Motion2DClip.NativeFieldInfoPtr_Curve = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Motion2DClip>.NativeClassPtr, nameof (Curve));
      Motion2DClip.NativeFieldInfoPtr_EasingCurve = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Motion2DClip>.NativeClassPtr, nameof (EasingCurve));
      Motion2DClip.NativeMethodInfoPtr__ctor_Public_Void_Il2CppStructArray_1_Byte_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Motion2DClip>.NativeClassPtr, 100663873);
    }

    public Motion2DClip(System.IntPtr pointer)
      : base(pointer)
    {
    }

    public unsafe Il2CppStructArray<byte> GUID
    {
      get
      {
        System.IntPtr nativeObject = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(Motion2DClip.NativeFieldInfoPtr_GUID));
        return nativeObject == System.IntPtr.Zero ? (Il2CppStructArray<byte>) null : new Il2CppStructArray<byte>(nativeObject);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(Motion2DClip.NativeFieldInfoPtr_GUID), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe string Name
    {
      get
      {
        return IL2CPP.Il2CppStringToManaged(*(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(Motion2DClip.NativeFieldInfoPtr_Name)));
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(Motion2DClip.NativeFieldInfoPtr_Name), IL2CPP.ManagedStringToIl2Cpp(value));
      }
    }

    public unsafe float Start
    {
      get
      {
        return *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(Motion2DClip.NativeFieldInfoPtr_Start));
      }
      [param: In] set
      {
        *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(Motion2DClip.NativeFieldInfoPtr_Start)) = value;
      }
    }

    public unsafe float Duration
    {
      get
      {
        return *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(Motion2DClip.NativeFieldInfoPtr_Duration));
      }
      [param: In] set
      {
        *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(Motion2DClip.NativeFieldInfoPtr_Duration)) = value;
      }
    }

    public unsafe Motion2DCurve Curve
    {
      get
      {
        System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(Motion2DClip.NativeFieldInfoPtr_Curve));
        return pointer == System.IntPtr.Zero ? (Motion2DCurve) null : new Motion2DCurve(pointer);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(Motion2DClip.NativeFieldInfoPtr_Curve), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe Motion2DEasings.Curve EasingCurve
    {
      get
      {
        return *(Motion2DEasings.Curve*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(Motion2DClip.NativeFieldInfoPtr_EasingCurve));
      }
      [param: In] set
      {
        *(Motion2DEasings.Curve*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(Motion2DClip.NativeFieldInfoPtr_EasingCurve)) = value;
      }
    }
  }
}
