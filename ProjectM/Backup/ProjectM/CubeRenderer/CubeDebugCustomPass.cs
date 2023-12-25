// Decompiled with JetBrains decompiler
// Type: ProjectM.CubeRenderer.CubeDebugCustomPass
// Assembly: ProjectM, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 83E42B70-D81B-4F1F-9FB5-6B5ABD5FF9FC
// Assembly location: C:\Users\mitch\.nuget\packages\vrising.unhollowed.client\0.6.5.57575090\lib\net6.0\ProjectM.dll

using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using System;
using System.Runtime.InteropServices;

#nullable disable
namespace ProjectM.CubeRenderer
{
  public class CubeDebugCustomPass : StunlockBehaviour
  {
    private static readonly IntPtr NativeFieldInfoPtr__Instance_k__BackingField;
    private static readonly IntPtr NativeMethodInfoPtr_get_Instance_Public_Static_get_CubeDebugCustomPass_0;
    private static readonly IntPtr NativeMethodInfoPtr_set_Instance_Private_Static_set_Void_CubeDebugCustomPass_0;
    private static readonly IntPtr NativeMethodInfoPtr_OnEnable_Private_Void_0;
    private static readonly IntPtr NativeMethodInfoPtr_OnDisable_Private_Void_0;
    private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

    public static unsafe CubeDebugCustomPass Instance
    {
      [CallerCount(0), CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1124127, XrefRangeEnd = 1124129, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] get
      {
        IntPtr* numPtr = (IntPtr*) null;
        IntPtr exc;
        IntPtr num = IL2CPP.il2cpp_runtime_invoke(CubeDebugCustomPass.NativeMethodInfoPtr_get_Instance_Public_Static_get_CubeDebugCustomPass_0, IntPtr.Zero, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
        IntPtr pointer = num;
        return pointer == IntPtr.Zero ? (CubeDebugCustomPass) null : new CubeDebugCustomPass(pointer);
      }
      [CallerCount(0), CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1124129, XrefRangeEnd = 1124132, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] set
      {
        IntPtr* numPtr = stackalloc IntPtr[1];
        numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value);
        IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(CubeDebugCustomPass.NativeMethodInfoPtr_set_Instance_Private_Static_set_Void_CubeDebugCustomPass_0, IntPtr.Zero, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1124132, XrefRangeEnd = 1124141, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe void OnEnable()
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IntPtr* numPtr = (IntPtr*) null;
      IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(CubeDebugCustomPass.NativeMethodInfoPtr_OnEnable_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1124141, XrefRangeEnd = 1124150, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe void OnDisable()
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IntPtr* numPtr = (IntPtr*) null;
      IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(CubeDebugCustomPass.NativeMethodInfoPtr_OnDisable_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(425)]
    [CachedScanResults(RefRangeStart = 315604, RefRangeEnd = 316029, XrefRangeStart = 315604, XrefRangeEnd = 316029, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe CubeDebugCustomPass()
      : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<CubeDebugCustomPass>.NativeClassPtr))
    {
      IntPtr* numPtr = (IntPtr*) null;
      IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(CubeDebugCustomPass.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    static CubeDebugCustomPass()
    {
      Il2CppClassPointerStore<CubeDebugCustomPass>.NativeClassPtr = IL2CPP.GetIl2CppClass("ProjectM.dll", "ProjectM.CubeRenderer", nameof (CubeDebugCustomPass));
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<CubeDebugCustomPass>.NativeClassPtr);
      CubeDebugCustomPass.NativeFieldInfoPtr__Instance_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CubeDebugCustomPass>.NativeClassPtr, "<Instance>k__BackingField");
      CubeDebugCustomPass.NativeMethodInfoPtr_get_Instance_Public_Static_get_CubeDebugCustomPass_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CubeDebugCustomPass>.NativeClassPtr, 100689193);
      CubeDebugCustomPass.NativeMethodInfoPtr_set_Instance_Private_Static_set_Void_CubeDebugCustomPass_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CubeDebugCustomPass>.NativeClassPtr, 100689194);
      CubeDebugCustomPass.NativeMethodInfoPtr_OnEnable_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CubeDebugCustomPass>.NativeClassPtr, 100689195);
      CubeDebugCustomPass.NativeMethodInfoPtr_OnDisable_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CubeDebugCustomPass>.NativeClassPtr, 100689196);
      CubeDebugCustomPass.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CubeDebugCustomPass>.NativeClassPtr, 100689197);
    }

    public CubeDebugCustomPass(IntPtr pointer)
      : base(pointer)
    {
    }

    public static unsafe CubeDebugCustomPass _Instance_k__BackingField
    {
      get
      {
        IntPtr num;
        IL2CPP.il2cpp_field_static_get_value(CubeDebugCustomPass.NativeFieldInfoPtr__Instance_k__BackingField, (void*) &num);
        IntPtr pointer = num;
        return pointer == IntPtr.Zero ? (CubeDebugCustomPass) null : new CubeDebugCustomPass(pointer);
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(CubeDebugCustomPass.NativeFieldInfoPtr__Instance_k__BackingField, (void*) IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }
  }
}
