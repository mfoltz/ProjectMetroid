// Decompiled with JetBrains decompiler
// Type: ProjectM.GiveAchievementOnSpawnAuthoring
// Assembly: ProjectM, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 83E42B70-D81B-4F1F-9FB5-6B5ABD5FF9FC
// Assembly location: C:\Users\mitch\.nuget\packages\vrising.unhollowed.client\0.6.5.57575090\lib\net6.0\ProjectM.dll

using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using ProjectM.Scripting;
using System;
using System.Runtime.InteropServices;
using Unity.Entities;

#nullable disable
namespace ProjectM
{
  public class GiveAchievementOnSpawnAuthoring : GameplayScriptBehaviour
  {
    private static readonly IntPtr NativeFieldInfoPtr_UnlockSpecificPrefab;
    private static readonly IntPtr NativeFieldInfoPtr_UnlockPrefabGuid;
    private static readonly IntPtr NativeMethodInfoPtr_Convert_Protected_Virtual_Void_Entity_EntityManager_GameObjectConversionSystem_0;
    private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 996923, XrefRangeEnd = 996927, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public override unsafe void Convert(
      Entity entity,
      EntityManager dstManager,
      GameObjectConversionSystem conversionSystem)
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IntPtr* numPtr = stackalloc IntPtr[3];
      numPtr[0] = (IntPtr) &entity;
      *(IntPtr*) ((IntPtr) numPtr + checked (new IntPtr(1) * sizeof (IntPtr))) = (IntPtr) &dstManager;
      *(IntPtr*) ((IntPtr) numPtr + checked (new IntPtr(2) * sizeof (IntPtr))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) conversionSystem);
      IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), GiveAchievementOnSpawnAuthoring.NativeMethodInfoPtr_Convert_Protected_Virtual_Void_Entity_EntityManager_GameObjectConversionSystem_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(41)]
    [CachedScanResults(RefRangeStart = 321963, RefRangeEnd = 322004, XrefRangeStart = 321963, XrefRangeEnd = 322004, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe GiveAchievementOnSpawnAuthoring()
      : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<GiveAchievementOnSpawnAuthoring>.NativeClassPtr))
    {
      IntPtr* numPtr = (IntPtr*) null;
      IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(GiveAchievementOnSpawnAuthoring.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    static GiveAchievementOnSpawnAuthoring()
    {
      Il2CppClassPointerStore<GiveAchievementOnSpawnAuthoring>.NativeClassPtr = IL2CPP.GetIl2CppClass("ProjectM.dll", "ProjectM", nameof (GiveAchievementOnSpawnAuthoring));
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<GiveAchievementOnSpawnAuthoring>.NativeClassPtr);
      GiveAchievementOnSpawnAuthoring.NativeFieldInfoPtr_UnlockSpecificPrefab = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GiveAchievementOnSpawnAuthoring>.NativeClassPtr, nameof (UnlockSpecificPrefab));
      GiveAchievementOnSpawnAuthoring.NativeFieldInfoPtr_UnlockPrefabGuid = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GiveAchievementOnSpawnAuthoring>.NativeClassPtr, nameof (UnlockPrefabGuid));
      GiveAchievementOnSpawnAuthoring.NativeMethodInfoPtr_Convert_Protected_Virtual_Void_Entity_EntityManager_GameObjectConversionSystem_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GiveAchievementOnSpawnAuthoring>.NativeClassPtr, 100677062);
      GiveAchievementOnSpawnAuthoring.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GiveAchievementOnSpawnAuthoring>.NativeClassPtr, 100677063);
    }

    public GiveAchievementOnSpawnAuthoring(IntPtr pointer)
      : base(pointer)
    {
    }

    public unsafe bool UnlockSpecificPrefab
    {
      get
      {
        return *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(GiveAchievementOnSpawnAuthoring.NativeFieldInfoPtr_UnlockSpecificPrefab));
      }
      [param: In] set
      {
        *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(GiveAchievementOnSpawnAuthoring.NativeFieldInfoPtr_UnlockSpecificPrefab)) = value;
      }
    }

    public unsafe WeakAssetReference<PrefabGuidComponent> UnlockPrefabGuid
    {
      get
      {
        IntPtr pointer = *(IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(GiveAchievementOnSpawnAuthoring.NativeFieldInfoPtr_UnlockPrefabGuid));
        return pointer == IntPtr.Zero ? (WeakAssetReference<PrefabGuidComponent>) null : new WeakAssetReference<PrefabGuidComponent>(pointer);
      }
      [param: In] set
      {
        IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(GiveAchievementOnSpawnAuthoring.NativeFieldInfoPtr_UnlockPrefabGuid), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public class Server : ServerScript
    {
      private static readonly IntPtr NativeMethodInfoPtr_Spawn_Protected_Static_Void_byref_ServerGameManager_byref_SelfServer_0;
      private static readonly IntPtr NativeMethodInfoPtr_CompleteAchievement_Private_Static_Void_ServerGameManager_PrefabGUID_Entity_SelfServer_0;
      private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

      [CallerCount(0)]
      [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 996885, XrefRangeEnd = 996912, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public static unsafe void Spawn(ref ServerGameManager game, [In] ref SelfServer self)
      {
        IntPtr* numPtr = stackalloc IntPtr[2];
        numPtr[0] = (IntPtr) ref game;
        *(IntPtr*) ((IntPtr) numPtr + checked (new IntPtr(1) * sizeof (IntPtr))) = (IntPtr) ref self;
        IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(GiveAchievementOnSpawnAuthoring.Server.NativeMethodInfoPtr_Spawn_Protected_Static_Void_byref_ServerGameManager_byref_SelfServer_0, IntPtr.Zero, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(1)]
      [CachedScanResults(RefRangeStart = 996922, RefRangeEnd = 996923, XrefRangeStart = 996912, XrefRangeEnd = 996922, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public static unsafe void CompleteAchievement(
        ServerGameManager game,
        PrefabGUID prefabGuid,
        Entity owner,
        SelfServer self)
      {
        IntPtr* numPtr = stackalloc IntPtr[4];
        numPtr[0] = (IntPtr) &game;
        *(IntPtr*) ((IntPtr) numPtr + checked (new IntPtr(1) * sizeof (IntPtr))) = (IntPtr) &prefabGuid;
        *(IntPtr*) ((IntPtr) numPtr + checked (new IntPtr(2) * sizeof (IntPtr))) = (IntPtr) &owner;
        *(IntPtr*) ((IntPtr) numPtr + checked (new IntPtr(3) * sizeof (IntPtr))) = (IntPtr) &self;
        IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(GiveAchievementOnSpawnAuthoring.Server.NativeMethodInfoPtr_CompleteAchievement_Private_Static_Void_ServerGameManager_PrefabGUID_Entity_SelfServer_0, IntPtr.Zero, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(1696)]
      [CachedScanResults(RefRangeStart = 37044, RefRangeEnd = 38740, XrefRangeStart = 37044, XrefRangeEnd = 38740, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe Server()
        : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<GiveAchievementOnSpawnAuthoring.Server>.NativeClassPtr))
      {
        IntPtr* numPtr = (IntPtr*) null;
        IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(GiveAchievementOnSpawnAuthoring.Server.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      static Server()
      {
        Il2CppClassPointerStore<GiveAchievementOnSpawnAuthoring.Server>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<GiveAchievementOnSpawnAuthoring>.NativeClassPtr, nameof (Server));
        IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<GiveAchievementOnSpawnAuthoring.Server>.NativeClassPtr);
        GiveAchievementOnSpawnAuthoring.Server.NativeMethodInfoPtr_Spawn_Protected_Static_Void_byref_ServerGameManager_byref_SelfServer_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GiveAchievementOnSpawnAuthoring.Server>.NativeClassPtr, 100677064);
        GiveAchievementOnSpawnAuthoring.Server.NativeMethodInfoPtr_CompleteAchievement_Private_Static_Void_ServerGameManager_PrefabGUID_Entity_SelfServer_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GiveAchievementOnSpawnAuthoring.Server>.NativeClassPtr, 100677065);
        GiveAchievementOnSpawnAuthoring.Server.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GiveAchievementOnSpawnAuthoring.Server>.NativeClassPtr, 100677066);
      }

      public Server(IntPtr pointer)
        : base(pointer)
      {
      }
    }
  }
}
