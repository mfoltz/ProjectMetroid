// Decompiled with JetBrains decompiler
// Type: ProjectM.UIAssetSubSceneLoader_ClientWorld
// Assembly: ProjectM, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 83E42B70-D81B-4F1F-9FB5-6B5ABD5FF9FC
// Assembly location: C:\Users\mitch\.nuget\packages\vrising.unhollowed.client\0.6.5.57575090\lib\net6.0\ProjectM.dll

using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using System;
using System.Runtime.InteropServices;

#nullable disable
namespace ProjectM
{
  public class UIAssetSubSceneLoader_ClientWorld : AssetSubSceneStreamingHandler
  {
    private static readonly IntPtr NativeFieldInfoPtr__ClientBootstrapSystem;
    private static readonly IntPtr NativeMethodInfoPtr_GetSubSceneGUID_Protected_Virtual_SubSceneGUID_0;
    private static readonly IntPtr NativeMethodInfoPtr_OnCreate_Protected_Virtual_Void_0;
    private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
    private static readonly IntPtr NativeMethodInfoPtr_OnCreateForCompiler_FamOrAssem_Virtual_Void_0;

    [CallerCount(0)]
    public override unsafe SubSceneGUID GetSubSceneGUID()
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IntPtr* numPtr = (IntPtr*) null;
      IntPtr exc;
      IntPtr num = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), UIAssetSubSceneLoader_ClientWorld.NativeMethodInfoPtr_GetSubSceneGUID_Protected_Virtual_SubSceneGUID_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(SubSceneGUID*) IL2CPP.il2cpp_object_unbox(num);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1073223, XrefRangeEnd = 1073230, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public override unsafe void OnCreate()
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IntPtr* numPtr = (IntPtr*) null;
      IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), UIAssetSubSceneLoader_ClientWorld.NativeMethodInfoPtr_OnCreate_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe UIAssetSubSceneLoader_ClientWorld()
      : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<UIAssetSubSceneLoader_ClientWorld>.NativeClassPtr))
    {
      IntPtr* numPtr = (IntPtr*) null;
      IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(UIAssetSubSceneLoader_ClientWorld.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public override unsafe void OnCreateForCompiler()
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IntPtr* numPtr = (IntPtr*) null;
      IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), UIAssetSubSceneLoader_ClientWorld.NativeMethodInfoPtr_OnCreateForCompiler_FamOrAssem_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    static UIAssetSubSceneLoader_ClientWorld()
    {
      Il2CppClassPointerStore<UIAssetSubSceneLoader_ClientWorld>.NativeClassPtr = IL2CPP.GetIl2CppClass("ProjectM.dll", "ProjectM", nameof (UIAssetSubSceneLoader_ClientWorld));
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<UIAssetSubSceneLoader_ClientWorld>.NativeClassPtr);
      UIAssetSubSceneLoader_ClientWorld.NativeFieldInfoPtr__ClientBootstrapSystem = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UIAssetSubSceneLoader_ClientWorld>.NativeClassPtr, nameof (_ClientBootstrapSystem));
      UIAssetSubSceneLoader_ClientWorld.NativeMethodInfoPtr_GetSubSceneGUID_Protected_Virtual_SubSceneGUID_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UIAssetSubSceneLoader_ClientWorld>.NativeClassPtr, 100684550);
      UIAssetSubSceneLoader_ClientWorld.NativeMethodInfoPtr_OnCreate_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UIAssetSubSceneLoader_ClientWorld>.NativeClassPtr, 100684551);
      UIAssetSubSceneLoader_ClientWorld.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UIAssetSubSceneLoader_ClientWorld>.NativeClassPtr, 100684552);
      UIAssetSubSceneLoader_ClientWorld.NativeMethodInfoPtr_OnCreateForCompiler_FamOrAssem_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UIAssetSubSceneLoader_ClientWorld>.NativeClassPtr, 100684553);
    }

    public UIAssetSubSceneLoader_ClientWorld(IntPtr pointer)
      : base(pointer)
    {
    }

    public unsafe ClientBootstrapSystem _ClientBootstrapSystem
    {
      get
      {
        IntPtr pointer = *(IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(UIAssetSubSceneLoader_ClientWorld.NativeFieldInfoPtr__ClientBootstrapSystem));
        return pointer == IntPtr.Zero ? (ClientBootstrapSystem) null : new ClientBootstrapSystem(pointer);
      }
      [param: In] set
      {
        IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(UIAssetSubSceneLoader_ClientWorld.NativeFieldInfoPtr__ClientBootstrapSystem), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }
  }
}
