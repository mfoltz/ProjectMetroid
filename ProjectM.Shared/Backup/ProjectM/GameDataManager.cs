// Decompiled with JetBrains decompiler
// Type: ProjectM.GameDataManager
// Assembly: ProjectM.Shared, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: CF03A298-FF93-4294-AFD6-565AD334A53C
// Assembly location: C:\Users\mitch\.nuget\packages\vrising.unhollowed.client\0.6.5.57575090\lib\net6.0\ProjectM.Shared.dll

using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using System;
using System.Runtime.InteropServices;
using Unity.Entities;

#nullable disable
namespace ProjectM
{
  public class GameDataManager : SystemBase
  {
    private static readonly IntPtr NativeFieldInfoPtr_GameDataInitialized;
    private static readonly IntPtr NativeFieldInfoPtr__LoadingStartedQuery;
    private static readonly IntPtr NativeFieldInfoPtr__GameDataQuery;
    private static readonly IntPtr NativeFieldInfoPtr__LoadingSubSceneQuery;
    private static readonly IntPtr NativeFieldInfoPtr__RegisterPrefabQuery;
    private static readonly IntPtr NativeFieldInfoPtr__SingletonEntityQuery_WorldTypeSingleton_0;
    private static readonly IntPtr NativeMethodInfoPtr_OnCreate_Protected_Virtual_Void_0;
    private static readonly IntPtr NativeMethodInfoPtr_OnUpdate_Protected_Virtual_Void_0;
    private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
    private static readonly IntPtr NativeMethodInfoPtr_OnCreateForCompiler_FamOrAssem_Virtual_Void_0;

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 735073, XrefRangeEnd = 735136, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public override unsafe void OnCreate()
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IntPtr* numPtr = (IntPtr*) null;
      IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), GameDataManager.NativeMethodInfoPtr_OnCreate_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 735136, XrefRangeEnd = 735184, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public override unsafe void OnUpdate()
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IntPtr* numPtr = (IntPtr*) null;
      IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), GameDataManager.NativeMethodInfoPtr_OnUpdate_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(105)]
    [CachedScanResults(RefRangeStart = 73174, RefRangeEnd = 73279, XrefRangeStart = 73174, XrefRangeEnd = 73279, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe GameDataManager()
      : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<GameDataManager>.NativeClassPtr))
    {
      IntPtr* numPtr = (IntPtr*) null;
      IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(GameDataManager.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 735184, XrefRangeEnd = 735192, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public override unsafe void OnCreateForCompiler()
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IntPtr* numPtr = (IntPtr*) null;
      IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), GameDataManager.NativeMethodInfoPtr_OnCreateForCompiler_FamOrAssem_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    static GameDataManager()
    {
      Il2CppClassPointerStore<GameDataManager>.NativeClassPtr = IL2CPP.GetIl2CppClass("ProjectM.Shared.dll", "ProjectM", nameof (GameDataManager));
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<GameDataManager>.NativeClassPtr);
      GameDataManager.NativeFieldInfoPtr_GameDataInitialized = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GameDataManager>.NativeClassPtr, nameof (GameDataInitialized));
      GameDataManager.NativeFieldInfoPtr__LoadingStartedQuery = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GameDataManager>.NativeClassPtr, nameof (_LoadingStartedQuery));
      GameDataManager.NativeFieldInfoPtr__GameDataQuery = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GameDataManager>.NativeClassPtr, nameof (_GameDataQuery));
      GameDataManager.NativeFieldInfoPtr__LoadingSubSceneQuery = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GameDataManager>.NativeClassPtr, nameof (_LoadingSubSceneQuery));
      GameDataManager.NativeFieldInfoPtr__RegisterPrefabQuery = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GameDataManager>.NativeClassPtr, nameof (_RegisterPrefabQuery));
      GameDataManager.NativeFieldInfoPtr__SingletonEntityQuery_WorldTypeSingleton_0 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GameDataManager>.NativeClassPtr, nameof (_SingletonEntityQuery_WorldTypeSingleton_0));
      GameDataManager.NativeMethodInfoPtr_OnCreate_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GameDataManager>.NativeClassPtr, 100664913);
      GameDataManager.NativeMethodInfoPtr_OnUpdate_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GameDataManager>.NativeClassPtr, 100664914);
      GameDataManager.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GameDataManager>.NativeClassPtr, 100664915);
      GameDataManager.NativeMethodInfoPtr_OnCreateForCompiler_FamOrAssem_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GameDataManager>.NativeClassPtr, 100664916);
    }

    public GameDataManager(IntPtr pointer)
      : base(pointer)
    {
    }

    public unsafe bool GameDataInitialized
    {
      get
      {
        return *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(GameDataManager.NativeFieldInfoPtr_GameDataInitialized));
      }
      [param: In] set
      {
        *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(GameDataManager.NativeFieldInfoPtr_GameDataInitialized)) = value;
      }
    }

    public unsafe EntityQuery _LoadingStartedQuery
    {
      get
      {
        return *(EntityQuery*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(GameDataManager.NativeFieldInfoPtr__LoadingStartedQuery));
      }
      [param: In] set
      {
        *(EntityQuery*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(GameDataManager.NativeFieldInfoPtr__LoadingStartedQuery)) = value;
      }
    }

    public unsafe EntityQuery _GameDataQuery
    {
      get
      {
        return *(EntityQuery*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(GameDataManager.NativeFieldInfoPtr__GameDataQuery));
      }
      [param: In] set
      {
        *(EntityQuery*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(GameDataManager.NativeFieldInfoPtr__GameDataQuery)) = value;
      }
    }

    public unsafe EntityQuery _LoadingSubSceneQuery
    {
      get
      {
        return *(EntityQuery*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(GameDataManager.NativeFieldInfoPtr__LoadingSubSceneQuery));
      }
      [param: In] set
      {
        *(EntityQuery*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(GameDataManager.NativeFieldInfoPtr__LoadingSubSceneQuery)) = value;
      }
    }

    public unsafe EntityQuery _RegisterPrefabQuery
    {
      get
      {
        return *(EntityQuery*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(GameDataManager.NativeFieldInfoPtr__RegisterPrefabQuery));
      }
      [param: In] set
      {
        *(EntityQuery*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(GameDataManager.NativeFieldInfoPtr__RegisterPrefabQuery)) = value;
      }
    }

    public unsafe EntityQuery _SingletonEntityQuery_WorldTypeSingleton_0
    {
      get
      {
        return *(EntityQuery*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(GameDataManager.NativeFieldInfoPtr__SingletonEntityQuery_WorldTypeSingleton_0));
      }
      [param: In] set
      {
        *(EntityQuery*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(GameDataManager.NativeFieldInfoPtr__SingletonEntityQuery_WorldTypeSingleton_0)) = value;
      }
    }
  }
}
