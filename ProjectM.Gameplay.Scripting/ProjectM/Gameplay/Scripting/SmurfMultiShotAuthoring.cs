// Decompiled with JetBrains decompiler
// Type: ProjectM.Gameplay.Scripting.SmurfMultiShotAuthoring
// Assembly: ProjectM.Gameplay.Scripting, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 87A11602-D28B-4E70-A33D-8BBFD694EEEF
// Assembly location: C:\Users\mitch\.nuget\packages\vrising.unhollowed.client\0.6.5.57575090\lib\net6.0\ProjectM.Gameplay.Scripting.dll

using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using ProjectM.CastleBuilding.Placement;
using ProjectM.Scripting;
using System;
using System.Runtime.InteropServices;
using Unity.Entities;

#nullable disable
namespace ProjectM.Gameplay.Scripting
{
  public class SmurfMultiShotAuthoring : GameplayScriptBehaviour
  {
    private static readonly IntPtr NativeFieldInfoPtr_ProjectileComponent;
    private static readonly IntPtr NativeFieldInfoPtr_PrefabForPlacementRules;
    private static readonly IntPtr NativeFieldInfoPtr_Count;
    private static readonly IntPtr NativeFieldInfoPtr_Angle;
    private static readonly IntPtr NativeMethodInfoPtr_Convert_Protected_Virtual_Void_Entity_EntityManager_GameObjectConversionSystem_0;
    private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1189602, XrefRangeEnd = 1189607, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
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
      IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), SmurfMultiShotAuthoring.NativeMethodInfoPtr_Convert_Protected_Virtual_Void_Entity_EntityManager_GameObjectConversionSystem_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1189607, XrefRangeEnd = 1189608, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe SmurfMultiShotAuthoring()
      : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<SmurfMultiShotAuthoring>.NativeClassPtr))
    {
      IntPtr* numPtr = (IntPtr*) null;
      IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(SmurfMultiShotAuthoring.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    static SmurfMultiShotAuthoring()
    {
      Il2CppClassPointerStore<SmurfMultiShotAuthoring>.NativeClassPtr = IL2CPP.GetIl2CppClass("ProjectM.Gameplay.Scripting.dll", "ProjectM.Gameplay.Scripting", nameof (SmurfMultiShotAuthoring));
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<SmurfMultiShotAuthoring>.NativeClassPtr);
      SmurfMultiShotAuthoring.NativeFieldInfoPtr_ProjectileComponent = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SmurfMultiShotAuthoring>.NativeClassPtr, nameof (ProjectileComponent));
      SmurfMultiShotAuthoring.NativeFieldInfoPtr_PrefabForPlacementRules = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SmurfMultiShotAuthoring>.NativeClassPtr, nameof (PrefabForPlacementRules));
      SmurfMultiShotAuthoring.NativeFieldInfoPtr_Count = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SmurfMultiShotAuthoring>.NativeClassPtr, nameof (Count));
      SmurfMultiShotAuthoring.NativeFieldInfoPtr_Angle = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SmurfMultiShotAuthoring>.NativeClassPtr, nameof (Angle));
      SmurfMultiShotAuthoring.NativeMethodInfoPtr_Convert_Protected_Virtual_Void_Entity_EntityManager_GameObjectConversionSystem_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SmurfMultiShotAuthoring>.NativeClassPtr, 100664850);
      SmurfMultiShotAuthoring.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SmurfMultiShotAuthoring>.NativeClassPtr, 100664851);
    }

    public SmurfMultiShotAuthoring(IntPtr pointer)
      : base(pointer)
    {
    }

    public unsafe PrefabGuidComponent ProjectileComponent
    {
      get
      {
        IntPtr pointer = *(IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(SmurfMultiShotAuthoring.NativeFieldInfoPtr_ProjectileComponent));
        return pointer == IntPtr.Zero ? (PrefabGuidComponent) null : new PrefabGuidComponent(pointer);
      }
      [param: In] set
      {
        IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(SmurfMultiShotAuthoring.NativeFieldInfoPtr_ProjectileComponent), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe PrefabGuidComponent PrefabForPlacementRules
    {
      get
      {
        IntPtr pointer = *(IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(SmurfMultiShotAuthoring.NativeFieldInfoPtr_PrefabForPlacementRules));
        return pointer == IntPtr.Zero ? (PrefabGuidComponent) null : new PrefabGuidComponent(pointer);
      }
      [param: In] set
      {
        IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(SmurfMultiShotAuthoring.NativeFieldInfoPtr_PrefabForPlacementRules), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe int Count
    {
      get
      {
        return *(int*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(SmurfMultiShotAuthoring.NativeFieldInfoPtr_Count));
      }
      [param: In] set
      {
        *(int*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(SmurfMultiShotAuthoring.NativeFieldInfoPtr_Count)) = value;
      }
    }

    public unsafe float Angle
    {
      get
      {
        return *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(SmurfMultiShotAuthoring.NativeFieldInfoPtr_Angle));
      }
      [param: In] set
      {
        *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(SmurfMultiShotAuthoring.NativeFieldInfoPtr_Angle)) = value;
      }
    }

    public class Server : ServerScript
    {
      private static readonly IntPtr NativeMethodInfoPtr_MultiShotSpawn_Protected_Static_Void_byref_ServerGameManager_byref_SelfServer_byref_AbilityCastEndedData_0;
      private static readonly IntPtr NativeMethodInfoPtr_OnGetPlacementResult_Private_Static_Void_byref_ServerGameManager_byref_SelfServer_PlacementResult_0;
      private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

      [CallerCount(0)]
      [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1189548, XrefRangeEnd = 1189571, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public static unsafe void MultiShotSpawn(
        ref ServerGameManager game,
        [In] ref SelfServer self,
        [In] ref AbilityCastEndedData castData)
      {
        IntPtr* numPtr = stackalloc IntPtr[3];
        numPtr[0] = (IntPtr) ref game;
        *(IntPtr*) ((IntPtr) numPtr + checked (new IntPtr(1) * sizeof (IntPtr))) = (IntPtr) ref self;
        *(IntPtr*) ((IntPtr) numPtr + checked (new IntPtr(2) * sizeof (IntPtr))) = (IntPtr) ref castData;
        IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(SmurfMultiShotAuthoring.Server.NativeMethodInfoPtr_MultiShotSpawn_Protected_Static_Void_byref_ServerGameManager_byref_SelfServer_byref_AbilityCastEndedData_0, IntPtr.Zero, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(0)]
      [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1189571, XrefRangeEnd = 1189602, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public static unsafe void OnGetPlacementResult(
        ref ServerGameManager game,
        [In] ref SelfServer self,
        PlacementResult placementResult)
      {
        IntPtr* numPtr = stackalloc IntPtr[3];
        numPtr[0] = (IntPtr) ref game;
        *(IntPtr*) ((IntPtr) numPtr + checked (new IntPtr(1) * sizeof (IntPtr))) = (IntPtr) ref self;
        *(IntPtr*) ((IntPtr) numPtr + checked (new IntPtr(2) * sizeof (IntPtr))) = (IntPtr) &placementResult;
        IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(SmurfMultiShotAuthoring.Server.NativeMethodInfoPtr_OnGetPlacementResult_Private_Static_Void_byref_ServerGameManager_byref_SelfServer_PlacementResult_0, IntPtr.Zero, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(1696)]
      [CachedScanResults(RefRangeStart = 37044, RefRangeEnd = 38740, XrefRangeStart = 37044, XrefRangeEnd = 38740, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe Server()
        : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<SmurfMultiShotAuthoring.Server>.NativeClassPtr))
      {
        IntPtr* numPtr = (IntPtr*) null;
        IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(SmurfMultiShotAuthoring.Server.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      static Server()
      {
        Il2CppClassPointerStore<SmurfMultiShotAuthoring.Server>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<SmurfMultiShotAuthoring>.NativeClassPtr, nameof (Server));
        IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<SmurfMultiShotAuthoring.Server>.NativeClassPtr);
        SmurfMultiShotAuthoring.Server.NativeMethodInfoPtr_MultiShotSpawn_Protected_Static_Void_byref_ServerGameManager_byref_SelfServer_byref_AbilityCastEndedData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SmurfMultiShotAuthoring.Server>.NativeClassPtr, 100664852);
        SmurfMultiShotAuthoring.Server.NativeMethodInfoPtr_OnGetPlacementResult_Private_Static_Void_byref_ServerGameManager_byref_SelfServer_PlacementResult_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SmurfMultiShotAuthoring.Server>.NativeClassPtr, 100664853);
        SmurfMultiShotAuthoring.Server.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SmurfMultiShotAuthoring.Server>.NativeClassPtr, 100664854);
      }

      public Server(IntPtr pointer)
        : base(pointer)
      {
      }
    }
  }
}
