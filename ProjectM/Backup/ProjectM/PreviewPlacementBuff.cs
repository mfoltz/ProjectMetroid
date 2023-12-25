// Decompiled with JetBrains decompiler
// Type: ProjectM.PreviewPlacementBuff
// Assembly: ProjectM, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 83E42B70-D81B-4F1F-9FB5-6B5ABD5FF9FC
// Assembly location: C:\Users\mitch\.nuget\packages\vrising.unhollowed.client\0.6.5.57575090\lib\net6.0\ProjectM.dll

using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppSystem;
using System.Runtime.InteropServices;
using Unity.Entities;
using Unity.Mathematics;
using UnityEngine;

#nullable disable
namespace ProjectM
{
  [StructLayout(LayoutKind.Explicit)]
  public struct PreviewPlacementBuff
  {
    private static readonly System.IntPtr NativeFieldInfoPtr_LastRotation;
    private static readonly System.IntPtr NativeFieldInfoPtr_MouseWorldPosition;
    private static readonly System.IntPtr NativeFieldInfoPtr_MouseWorldPositionPlayerPlaneTerrainProjection;
    private static readonly System.IntPtr NativeFieldInfoPtr_LastSnappedPosition;
    private static readonly System.IntPtr NativeFieldInfoPtr_Rotation;
    private static readonly System.IntPtr NativeFieldInfoPtr_Target;
    private static readonly System.IntPtr NativeFieldInfoPtr_PreviewEntity;
    private static readonly System.IntPtr NativeFieldInfoPtr_EditingEntity;
    private static readonly System.IntPtr NativeFieldInfoPtr_TransformingEntity;
    private static readonly System.IntPtr NativeFieldInfoPtr_BlueprintPrefabGuid;
    private static readonly System.IntPtr NativeFieldInfoPtr_PreviewPrefabGuid;
    private static readonly System.IntPtr NativeFieldInfoPtr_PlacementMode;
    private static readonly System.IntPtr NativeFieldInfoPtr_ForceAutoSnap;
    private static readonly System.IntPtr NativeFieldInfoPtr_AutoSnapToPoints;
    private static readonly System.IntPtr NativeFieldInfoPtr_AutoSnapToGrid;
    private static readonly System.IntPtr NativeFieldInfoPtr_HideUntilMoved;
    private static readonly System.IntPtr NativeMethodInfoPtr_CreatePreviewSequence_Public_PreviewPlacementSequence_EntityManager_Entity_Entity_Boolean_PrefabLookupMap_0;
    [FieldOffset(0)]
    public Nullable_Unboxed<Quaternion> LastRotation;
    [FieldOffset(20)]
    public float3 MouseWorldPosition;
    [FieldOffset(32)]
    public float3 MouseWorldPositionPlayerPlaneTerrainProjection;
    [FieldOffset(44)]
    public Nullable_Unboxed<float3> LastSnappedPosition;
    [FieldOffset(60)]
    public float Rotation;
    [FieldOffset(64)]
    public Entity Target;
    [FieldOffset(72)]
    public Entity PreviewEntity;
    [FieldOffset(80)]
    public Entity EditingEntity;
    [FieldOffset(88)]
    public Entity TransformingEntity;
    [FieldOffset(96)]
    public PrefabGUID BlueprintPrefabGuid;
    [FieldOffset(100)]
    public PrefabGUID PreviewPrefabGuid;
    [FieldOffset(104)]
    public PlacementMode PlacementMode;
    [FieldOffset(108)]
    public bool AutoSnapToPoints;
    [FieldOffset(109)]
    public bool AutoSnapToGrid;
    [FieldOffset(110)]
    public bool HideUntilMoved;

    [CallerCount(1)]
    [CachedScanResults(RefRangeStart = 1001379, RefRangeEnd = 1001380, XrefRangeStart = 1001363, XrefRangeEnd = 1001379, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe PreviewPlacementSequence CreatePreviewSequence(
      EntityManager entityManager,
      Entity blueprintPrefab,
      Entity previewInstance,
      bool isPlacementValid,
      PrefabLookupMap prefabLookupMap)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[5];
      numPtr[0] = (System.IntPtr) &entityManager;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &blueprintPrefab;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = (System.IntPtr) &previewInstance;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(3) * sizeof (System.IntPtr))) = (System.IntPtr) &isPlacementValid;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(4) * sizeof (System.IntPtr))) = (System.IntPtr) &prefabLookupMap;
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(PreviewPlacementBuff.NativeMethodInfoPtr_CreatePreviewSequence_Public_PreviewPlacementSequence_EntityManager_Entity_Entity_Boolean_PrefabLookupMap_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(PreviewPlacementSequence*) IL2CPP.il2cpp_object_unbox(num);
    }

    static PreviewPlacementBuff()
    {
      Il2CppClassPointerStore<PreviewPlacementBuff>.NativeClassPtr = IL2CPP.GetIl2CppClass("ProjectM.dll", "ProjectM", nameof (PreviewPlacementBuff));
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<PreviewPlacementBuff>.NativeClassPtr);
      PreviewPlacementBuff.NativeFieldInfoPtr_LastRotation = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PreviewPlacementBuff>.NativeClassPtr, nameof (LastRotation));
      PreviewPlacementBuff.NativeFieldInfoPtr_MouseWorldPosition = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PreviewPlacementBuff>.NativeClassPtr, nameof (MouseWorldPosition));
      PreviewPlacementBuff.NativeFieldInfoPtr_MouseWorldPositionPlayerPlaneTerrainProjection = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PreviewPlacementBuff>.NativeClassPtr, nameof (MouseWorldPositionPlayerPlaneTerrainProjection));
      PreviewPlacementBuff.NativeFieldInfoPtr_LastSnappedPosition = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PreviewPlacementBuff>.NativeClassPtr, nameof (LastSnappedPosition));
      PreviewPlacementBuff.NativeFieldInfoPtr_Rotation = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PreviewPlacementBuff>.NativeClassPtr, nameof (Rotation));
      PreviewPlacementBuff.NativeFieldInfoPtr_Target = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PreviewPlacementBuff>.NativeClassPtr, nameof (Target));
      PreviewPlacementBuff.NativeFieldInfoPtr_PreviewEntity = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PreviewPlacementBuff>.NativeClassPtr, nameof (PreviewEntity));
      PreviewPlacementBuff.NativeFieldInfoPtr_EditingEntity = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PreviewPlacementBuff>.NativeClassPtr, nameof (EditingEntity));
      PreviewPlacementBuff.NativeFieldInfoPtr_TransformingEntity = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PreviewPlacementBuff>.NativeClassPtr, nameof (TransformingEntity));
      PreviewPlacementBuff.NativeFieldInfoPtr_BlueprintPrefabGuid = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PreviewPlacementBuff>.NativeClassPtr, nameof (BlueprintPrefabGuid));
      PreviewPlacementBuff.NativeFieldInfoPtr_PreviewPrefabGuid = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PreviewPlacementBuff>.NativeClassPtr, nameof (PreviewPrefabGuid));
      PreviewPlacementBuff.NativeFieldInfoPtr_PlacementMode = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PreviewPlacementBuff>.NativeClassPtr, nameof (PlacementMode));
      PreviewPlacementBuff.NativeFieldInfoPtr_ForceAutoSnap = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PreviewPlacementBuff>.NativeClassPtr, nameof (ForceAutoSnap));
      PreviewPlacementBuff.NativeFieldInfoPtr_AutoSnapToPoints = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PreviewPlacementBuff>.NativeClassPtr, nameof (AutoSnapToPoints));
      PreviewPlacementBuff.NativeFieldInfoPtr_AutoSnapToGrid = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PreviewPlacementBuff>.NativeClassPtr, nameof (AutoSnapToGrid));
      PreviewPlacementBuff.NativeFieldInfoPtr_HideUntilMoved = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PreviewPlacementBuff>.NativeClassPtr, nameof (HideUntilMoved));
      PreviewPlacementBuff.NativeMethodInfoPtr_CreatePreviewSequence_Public_PreviewPlacementSequence_EntityManager_Entity_Entity_Boolean_PrefabLookupMap_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PreviewPlacementBuff>.NativeClassPtr, 100677513);
    }

    public Il2CppSystem.Object BoxIl2CppObject()
    {
      return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<PreviewPlacementBuff>.NativeClassPtr, (System.IntPtr) ref this));
    }

    public static unsafe bool ForceAutoSnap
    {
      get
      {
        bool forceAutoSnap;
        IL2CPP.il2cpp_field_static_get_value(PreviewPlacementBuff.NativeFieldInfoPtr_ForceAutoSnap, (void*) &forceAutoSnap);
        return forceAutoSnap;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(PreviewPlacementBuff.NativeFieldInfoPtr_ForceAutoSnap, (void*) &value);
      }
    }
  }
}
