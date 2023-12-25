// Decompiled with JetBrains decompiler
// Type: ProjectM.NetworkedSubScenePrefabSpawning
// Assembly: ProjectM, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 83E42B70-D81B-4F1F-9FB5-6B5ABD5FF9FC
// Assembly location: C:\Users\mitch\.nuget\packages\vrising.unhollowed.client\0.6.5.57575090\lib\net6.0\ProjectM.dll

using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppSystem;
using ProjectM.Gameplay;
using ProjectM.Tiles;
using System.Runtime.InteropServices;
using Unity.Entities;
using Unity.Transforms;

#nullable disable
namespace ProjectM
{
  public static class NetworkedSubScenePrefabSpawning : Il2CppSystem.Object
  {
    private static readonly System.IntPtr NativeMethodInfoPtr_InstantiatePrefabAndNetworkedChildren_Public_Static_Void_EntityCommandBuffer_byref_DataAccessors_Entity_Translation_Rotation_Entity_Boolean_Entity_Boolean_StaticTransformIndex_Nullable_Unboxed_1_Script_InspectTarget_Data_Nullable_Unboxed_1_ProfessorCoil_0;

    [CallerCount(2)]
    [CachedScanResults(RefRangeStart = 1084331, RefRangeEnd = 1084333, XrefRangeStart = 1084241, XrefRangeEnd = 1084331, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public static unsafe void InstantiatePrefabAndNetworkedChildren(
      EntityCommandBuffer spawnCommandBuffer,
      [In] ref NetworkedSubScenePrefabSpawning.DataAccessors spawnAccessors,
      Entity prefab,
      Translation translation,
      Rotation rotation,
      Entity teamEntity,
      bool setUserOwner,
      Entity userOwner,
      bool hasStaticTransformIndex,
      StaticTransformIndex staticTransformIndex,
      Nullable_Unboxed<Script_InspectTarget_Data> inspectTargetData = default (Nullable_Unboxed<Script_InspectTarget_Data>),
      Nullable_Unboxed<ProfessorCoil> professorCoil = default (Nullable_Unboxed<ProfessorCoil>))
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[12];
      numPtr[0] = (System.IntPtr) &spawnCommandBuffer;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) ref spawnAccessors;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = (System.IntPtr) &prefab;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(3) * sizeof (System.IntPtr))) = (System.IntPtr) &translation;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(4) * sizeof (System.IntPtr))) = (System.IntPtr) &rotation;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(5) * sizeof (System.IntPtr))) = (System.IntPtr) &teamEntity;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(6) * sizeof (System.IntPtr))) = (System.IntPtr) &setUserOwner;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(7) * sizeof (System.IntPtr))) = (System.IntPtr) &userOwner;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(8) * sizeof (System.IntPtr))) = (System.IntPtr) &hasStaticTransformIndex;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(9) * sizeof (System.IntPtr))) = (System.IntPtr) &staticTransformIndex;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(10) * sizeof (System.IntPtr))) = (System.IntPtr) &inspectTargetData;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(11) * sizeof (System.IntPtr))) = (System.IntPtr) &professorCoil;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(NetworkedSubScenePrefabSpawning.NativeMethodInfoPtr_InstantiatePrefabAndNetworkedChildren_Public_Static_Void_EntityCommandBuffer_byref_DataAccessors_Entity_Translation_Rotation_Entity_Boolean_Entity_Boolean_StaticTransformIndex_Nullable_Unboxed_1_Script_InspectTarget_Data_Nullable_Unboxed_1_ProfessorCoil_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    static NetworkedSubScenePrefabSpawning()
    {
      Il2CppClassPointerStore<NetworkedSubScenePrefabSpawning>.NativeClassPtr = IL2CPP.GetIl2CppClass("ProjectM.dll", "ProjectM", nameof (NetworkedSubScenePrefabSpawning));
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<NetworkedSubScenePrefabSpawning>.NativeClassPtr);
      NetworkedSubScenePrefabSpawning.NativeMethodInfoPtr_InstantiatePrefabAndNetworkedChildren_Public_Static_Void_EntityCommandBuffer_byref_DataAccessors_Entity_Translation_Rotation_Entity_Boolean_Entity_Boolean_StaticTransformIndex_Nullable_Unboxed_1_Script_InspectTarget_Data_Nullable_Unboxed_1_ProfessorCoil_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NetworkedSubScenePrefabSpawning>.NativeClassPtr, 100685429);
    }

    public NetworkedSubScenePrefabSpawning(System.IntPtr pointer)
      : base(pointer)
    {
    }

    [StructLayout(LayoutKind.Explicit)]
    public struct DataAccessors
    {
      private static readonly System.IntPtr NativeFieldInfoPtr_NetworkedPrefabChildrenFromEntity;
      private static readonly System.IntPtr NativeFieldInfoPtr_StaticTransformCompatibleFromEntity;
      private static readonly System.IntPtr NativeFieldInfoPtr_LastTranslationFromEntity;
      private static readonly System.IntPtr NativeFieldInfoPtr_UserOwnerFromEntity;
      private static readonly System.IntPtr NativeFieldInfoPtr_TeamReferenceFromEntity;
      private static readonly System.IntPtr NativeFieldInfoPtr_PrefabLookupMap;
      private static readonly System.IntPtr NativeMethodInfoPtr_Create_Public_Static_DataAccessors_ComponentSystemBase_PrefabLookupMap_0;
      [FieldOffset(0)]
      public ComponentDataFromEntity<NetworkedPrefabChildren> NetworkedPrefabChildrenFromEntity;
      [FieldOffset(32)]
      public ComponentDataFromEntity<StaticTransformCompatible> StaticTransformCompatibleFromEntity;
      [FieldOffset(64)]
      public ComponentDataFromEntity<LastTranslation> LastTranslationFromEntity;
      [FieldOffset(96)]
      public ComponentDataFromEntity<UserOwner> UserOwnerFromEntity;
      [FieldOffset(128)]
      public ComponentDataFromEntity<TeamReference> TeamReferenceFromEntity;
      [FieldOffset(160)]
      public PrefabLookupMap PrefabLookupMap;

      [CallerCount(1)]
      [CachedScanResults(RefRangeStart = 1084240, RefRangeEnd = 1084241, XrefRangeStart = 1084224, XrefRangeEnd = 1084240, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public static unsafe NetworkedSubScenePrefabSpawning.DataAccessors Create(
        ComponentSystemBase componentSystemBase,
        PrefabLookupMap prefabLookupMap)
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[2];
        numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) componentSystemBase);
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &prefabLookupMap;
        System.IntPtr exc;
        System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(NetworkedSubScenePrefabSpawning.DataAccessors.NativeMethodInfoPtr_Create_Public_Static_DataAccessors_ComponentSystemBase_PrefabLookupMap_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
        return *(NetworkedSubScenePrefabSpawning.DataAccessors*) IL2CPP.il2cpp_object_unbox(num);
      }

      static DataAccessors()
      {
        Il2CppClassPointerStore<NetworkedSubScenePrefabSpawning.DataAccessors>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<NetworkedSubScenePrefabSpawning>.NativeClassPtr, nameof (DataAccessors));
        IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<NetworkedSubScenePrefabSpawning.DataAccessors>.NativeClassPtr);
        NetworkedSubScenePrefabSpawning.DataAccessors.NativeFieldInfoPtr_NetworkedPrefabChildrenFromEntity = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NetworkedSubScenePrefabSpawning.DataAccessors>.NativeClassPtr, nameof (NetworkedPrefabChildrenFromEntity));
        NetworkedSubScenePrefabSpawning.DataAccessors.NativeFieldInfoPtr_StaticTransformCompatibleFromEntity = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NetworkedSubScenePrefabSpawning.DataAccessors>.NativeClassPtr, nameof (StaticTransformCompatibleFromEntity));
        NetworkedSubScenePrefabSpawning.DataAccessors.NativeFieldInfoPtr_LastTranslationFromEntity = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NetworkedSubScenePrefabSpawning.DataAccessors>.NativeClassPtr, nameof (LastTranslationFromEntity));
        NetworkedSubScenePrefabSpawning.DataAccessors.NativeFieldInfoPtr_UserOwnerFromEntity = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NetworkedSubScenePrefabSpawning.DataAccessors>.NativeClassPtr, nameof (UserOwnerFromEntity));
        NetworkedSubScenePrefabSpawning.DataAccessors.NativeFieldInfoPtr_TeamReferenceFromEntity = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NetworkedSubScenePrefabSpawning.DataAccessors>.NativeClassPtr, nameof (TeamReferenceFromEntity));
        NetworkedSubScenePrefabSpawning.DataAccessors.NativeFieldInfoPtr_PrefabLookupMap = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NetworkedSubScenePrefabSpawning.DataAccessors>.NativeClassPtr, nameof (PrefabLookupMap));
        NetworkedSubScenePrefabSpawning.DataAccessors.NativeMethodInfoPtr_Create_Public_Static_DataAccessors_ComponentSystemBase_PrefabLookupMap_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NetworkedSubScenePrefabSpawning.DataAccessors>.NativeClassPtr, 100685430);
      }

      public Il2CppSystem.Object BoxIl2CppObject()
      {
        return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<NetworkedSubScenePrefabSpawning.DataAccessors>.NativeClassPtr, (System.IntPtr) ref this));
      }
    }
  }
}
