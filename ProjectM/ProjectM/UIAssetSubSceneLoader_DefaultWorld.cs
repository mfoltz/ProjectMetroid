// Decompiled with JetBrains decompiler
// Type: ProjectM.UIAssetSubSceneLoader_DefaultWorld
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
  public class UIAssetSubSceneLoader_DefaultWorld : AssetSubSceneStreamingHandler
  {
    private static readonly IntPtr NativeFieldInfoPtr_SubSceneGUID;
    private static readonly IntPtr NativeMethodInfoPtr_GetSubSceneGUID_Protected_Virtual_SubSceneGUID_0;
    private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
    private static readonly IntPtr NativeMethodInfoPtr_OnCreateForCompiler_FamOrAssem_Virtual_Void_0;

    [CallerCount(0)]
    public override unsafe SubSceneGUID GetSubSceneGUID()
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IntPtr* numPtr = (IntPtr*) null;
      IntPtr exc;
      IntPtr num = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), UIAssetSubSceneLoader_DefaultWorld.NativeMethodInfoPtr_GetSubSceneGUID_Protected_Virtual_SubSceneGUID_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(SubSceneGUID*) IL2CPP.il2cpp_object_unbox(num);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe UIAssetSubSceneLoader_DefaultWorld()
      : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<UIAssetSubSceneLoader_DefaultWorld>.NativeClassPtr))
    {
      IntPtr* numPtr = (IntPtr*) null;
      IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(UIAssetSubSceneLoader_DefaultWorld.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public override unsafe void OnCreateForCompiler()
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IntPtr* numPtr = (IntPtr*) null;
      IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), UIAssetSubSceneLoader_DefaultWorld.NativeMethodInfoPtr_OnCreateForCompiler_FamOrAssem_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    static UIAssetSubSceneLoader_DefaultWorld()
    {
      Il2CppClassPointerStore<UIAssetSubSceneLoader_DefaultWorld>.NativeClassPtr = IL2CPP.GetIl2CppClass("ProjectM.dll", "ProjectM", nameof (UIAssetSubSceneLoader_DefaultWorld));
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<UIAssetSubSceneLoader_DefaultWorld>.NativeClassPtr);
      UIAssetSubSceneLoader_DefaultWorld.NativeFieldInfoPtr_SubSceneGUID = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UIAssetSubSceneLoader_DefaultWorld>.NativeClassPtr, nameof (SubSceneGUID));
      UIAssetSubSceneLoader_DefaultWorld.NativeMethodInfoPtr_GetSubSceneGUID_Protected_Virtual_SubSceneGUID_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UIAssetSubSceneLoader_DefaultWorld>.NativeClassPtr, 100684554);
      UIAssetSubSceneLoader_DefaultWorld.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UIAssetSubSceneLoader_DefaultWorld>.NativeClassPtr, 100684555);
      UIAssetSubSceneLoader_DefaultWorld.NativeMethodInfoPtr_OnCreateForCompiler_FamOrAssem_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UIAssetSubSceneLoader_DefaultWorld>.NativeClassPtr, 100684556);
    }

    public UIAssetSubSceneLoader_DefaultWorld(IntPtr pointer)
      : base(pointer)
    {
    }

    public unsafe SubSceneGUID SubSceneGUID
    {
      get
      {
        return *(SubSceneGUID*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(UIAssetSubSceneLoader_DefaultWorld.NativeFieldInfoPtr_SubSceneGUID));
      }
      [param: In] set
      {
        *(SubSceneGUID*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(UIAssetSubSceneLoader_DefaultWorld.NativeFieldInfoPtr_SubSceneGUID)) = value;
      }
    }
  }
}
