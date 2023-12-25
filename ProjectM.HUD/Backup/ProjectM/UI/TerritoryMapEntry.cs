// Decompiled with JetBrains decompiler
// Type: ProjectM.UI.TerritoryMapEntry
// Assembly: ProjectM.HUD, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 19DF27AB-2445-4ADB-A558-10C99A6E640A
// Assembly location: C:\Users\mitch\.nuget\packages\vrising.unhollowed.client\0.6.5.57575090\lib\net6.0\ProjectM.HUD.dll

using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using StunShared.UI;
using System;
using System.Runtime.InteropServices;
using UnityEngine;
using UnityEngine.UI;

#nullable disable
namespace ProjectM.UI
{
  public class TerritoryMapEntry : UIEntry
  {
    private static readonly IntPtr NativeFieldInfoPtr_TerritoryTextureCollection;
    private static readonly IntPtr NativeFieldInfoPtr_CastleTerritoryStateColors;
    private static readonly IntPtr NativeFieldInfoPtr_RectTransform;
    private static readonly IntPtr NativeFieldInfoPtr_Image;
    private static readonly IntPtr NativeFieldInfoPtr_PrevTerritoryTeam;
    private static readonly IntPtr NativeFieldInfoPtr_MinimapKeywordID;
    private static readonly IntPtr NativeFieldInfoPtr_VisibleColor;
    private static readonly IntPtr NativeFieldInfoPtr_InvisibleColor;
    private static readonly IntPtr NativeFieldInfoPtr_PrevZoom;
    private static readonly IntPtr NativeFieldInfoPtr_PrevTextureIndex;
    private static readonly IntPtr NativeFieldInfoPtr_PrevHovered;
    private static readonly IntPtr NativeFieldInfoPtr_HasInstancedMaterial;
    private static readonly IntPtr NativeFieldInfoPtr_RecentlyActivated;
    private static readonly IntPtr NativeFieldInfoPtr_MainTexID;
    private static readonly IntPtr NativeFieldInfoPtr_RevealTextureID;
    private static readonly IntPtr NativeFieldInfoPtr_MinXID;
    private static readonly IntPtr NativeFieldInfoPtr_MaxXID;
    private static readonly IntPtr NativeFieldInfoPtr_MinZID;
    private static readonly IntPtr NativeFieldInfoPtr_MaxZID;
    private static readonly IntPtr NativeFieldInfoPtr_TerritoryColorID;
    private static readonly IntPtr NativeFieldInfoPtr_InnerLineColorID;
    private static readonly IntPtr NativeFieldInfoPtr_OuterLineColorID;
    private static readonly IntPtr NativeFieldInfoPtr_EdgeThicknessID;
    private static readonly IntPtr NativeMethodInfoPtr_OnEnable_Private_Void_0;
    private static readonly IntPtr NativeMethodInfoPtr_OnDisable_Private_Void_0;
    private static readonly IntPtr NativeMethodInfoPtr_HasDataChangedMainMap_Public_Boolean_LocalTerritoryTeamStatus_Int32_Boolean_Single_0;
    private static readonly IntPtr NativeMethodInfoPtr_HasDataChangedMinimap_Public_Boolean_LocalTerritoryTeamStatus_Int32_0;
    private static readonly IntPtr NativeMethodInfoPtr_UpdatePosition_Public_Void_Vector2_Vector2_0;
    private static readonly IntPtr NativeMethodInfoPtr_SetData_Public_Void_Boolean_Int32_LocalTerritoryTeamStatus_Single_Boolean_Texture2D_Vector2_Single_Single_0;
    private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

    [CallerCount(0)]
    public unsafe void OnEnable()
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IntPtr* numPtr = (IntPtr*) null;
      IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(TerritoryMapEntry.NativeMethodInfoPtr_OnEnable_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1273787, XrefRangeEnd = 1273791, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe void OnDisable()
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IntPtr* numPtr = (IntPtr*) null;
      IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(TerritoryMapEntry.NativeMethodInfoPtr_OnDisable_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(1)]
    [CachedScanResults(RefRangeStart = 1273791, RefRangeEnd = 1273792, XrefRangeStart = 1273791, XrefRangeEnd = 1273791, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe bool HasDataChangedMainMap(
      TerritoryMapEntry.LocalTerritoryTeamStatus newTeam,
      int newTextureIndex,
      bool hovered,
      float zoomFactor)
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IntPtr* numPtr = stackalloc IntPtr[4];
      numPtr[0] = (IntPtr) &newTeam;
      *(IntPtr*) ((IntPtr) numPtr + checked (new IntPtr(1) * sizeof (IntPtr))) = (IntPtr) &newTextureIndex;
      *(IntPtr*) ((IntPtr) numPtr + checked (new IntPtr(2) * sizeof (IntPtr))) = (IntPtr) &hovered;
      *(IntPtr*) ((IntPtr) numPtr + checked (new IntPtr(3) * sizeof (IntPtr))) = (IntPtr) &zoomFactor;
      IntPtr exc;
      IntPtr num = IL2CPP.il2cpp_runtime_invoke(TerritoryMapEntry.NativeMethodInfoPtr_HasDataChangedMainMap_Public_Boolean_LocalTerritoryTeamStatus_Int32_Boolean_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(bool*) IL2CPP.il2cpp_object_unbox(num);
    }

    [CallerCount(1)]
    [CachedScanResults(RefRangeStart = 1273792, RefRangeEnd = 1273793, XrefRangeStart = 1273792, XrefRangeEnd = 1273792, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe bool HasDataChangedMinimap(
      TerritoryMapEntry.LocalTerritoryTeamStatus newTeam,
      int newTextureIndex)
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IntPtr* numPtr = stackalloc IntPtr[2];
      numPtr[0] = (IntPtr) &newTeam;
      *(IntPtr*) ((IntPtr) numPtr + checked (new IntPtr(1) * sizeof (IntPtr))) = (IntPtr) &newTextureIndex;
      IntPtr exc;
      IntPtr num = IL2CPP.il2cpp_runtime_invoke(TerritoryMapEntry.NativeMethodInfoPtr_HasDataChangedMinimap_Public_Boolean_LocalTerritoryTeamStatus_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(bool*) IL2CPP.il2cpp_object_unbox(num);
    }

    [CallerCount(2)]
    [CachedScanResults(RefRangeStart = 1273845, RefRangeEnd = 1273847, XrefRangeStart = 1273793, XrefRangeEnd = 1273845, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe void UpdatePosition(Vector2 position2D, Vector2 scale)
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IntPtr* numPtr = stackalloc IntPtr[2];
      numPtr[0] = (IntPtr) &position2D;
      *(IntPtr*) ((IntPtr) numPtr + checked (new IntPtr(1) * sizeof (IntPtr))) = (IntPtr) &scale;
      IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(TerritoryMapEntry.NativeMethodInfoPtr_UpdatePosition_Public_Void_Vector2_Vector2_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(2)]
    [CachedScanResults(RefRangeStart = 1273861, RefRangeEnd = 1273863, XrefRangeStart = 1273847, XrefRangeEnd = 1273861, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe void SetData(
      bool minimap,
      int globalTerritoryIndex,
      TerritoryMapEntry.LocalTerritoryTeamStatus teamStatus,
      float zoomFactor,
      bool hovered,
      Texture2D revealTexture,
      Vector2 centerPosWS,
      float width,
      float height)
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IntPtr* numPtr = stackalloc IntPtr[9];
      numPtr[0] = (IntPtr) &minimap;
      *(IntPtr*) ((IntPtr) numPtr + checked (new IntPtr(1) * sizeof (IntPtr))) = (IntPtr) &globalTerritoryIndex;
      *(IntPtr*) ((IntPtr) numPtr + checked (new IntPtr(2) * sizeof (IntPtr))) = (IntPtr) &teamStatus;
      *(IntPtr*) ((IntPtr) numPtr + checked (new IntPtr(3) * sizeof (IntPtr))) = (IntPtr) &zoomFactor;
      *(IntPtr*) ((IntPtr) numPtr + checked (new IntPtr(4) * sizeof (IntPtr))) = (IntPtr) &hovered;
      *(IntPtr*) ((IntPtr) numPtr + checked (new IntPtr(5) * sizeof (IntPtr))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) revealTexture);
      *(IntPtr*) ((IntPtr) numPtr + checked (new IntPtr(6) * sizeof (IntPtr))) = (IntPtr) &centerPosWS;
      *(IntPtr*) ((IntPtr) numPtr + checked (new IntPtr(7) * sizeof (IntPtr))) = (IntPtr) &width;
      *(IntPtr*) ((IntPtr) numPtr + checked (new IntPtr(8) * sizeof (IntPtr))) = (IntPtr) &height;
      IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(TerritoryMapEntry.NativeMethodInfoPtr_SetData_Public_Void_Boolean_Int32_LocalTerritoryTeamStatus_Single_Boolean_Texture2D_Vector2_Single_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1273863, XrefRangeEnd = 1273864, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe TerritoryMapEntry()
      : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<TerritoryMapEntry>.NativeClassPtr))
    {
      IntPtr* numPtr = (IntPtr*) null;
      IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(TerritoryMapEntry.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    static TerritoryMapEntry()
    {
      Il2CppClassPointerStore<TerritoryMapEntry>.NativeClassPtr = IL2CPP.GetIl2CppClass("ProjectM.HUD.dll", "ProjectM.UI", nameof (TerritoryMapEntry));
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<TerritoryMapEntry>.NativeClassPtr);
      TerritoryMapEntry.NativeFieldInfoPtr_TerritoryTextureCollection = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TerritoryMapEntry>.NativeClassPtr, nameof (TerritoryTextureCollection));
      TerritoryMapEntry.NativeFieldInfoPtr_CastleTerritoryStateColors = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TerritoryMapEntry>.NativeClassPtr, nameof (CastleTerritoryStateColors));
      TerritoryMapEntry.NativeFieldInfoPtr_RectTransform = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TerritoryMapEntry>.NativeClassPtr, nameof (RectTransform));
      TerritoryMapEntry.NativeFieldInfoPtr_Image = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TerritoryMapEntry>.NativeClassPtr, nameof (Image));
      TerritoryMapEntry.NativeFieldInfoPtr_PrevTerritoryTeam = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TerritoryMapEntry>.NativeClassPtr, nameof (PrevTerritoryTeam));
      TerritoryMapEntry.NativeFieldInfoPtr_MinimapKeywordID = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TerritoryMapEntry>.NativeClassPtr, nameof (MinimapKeywordID));
      TerritoryMapEntry.NativeFieldInfoPtr_VisibleColor = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TerritoryMapEntry>.NativeClassPtr, nameof (VisibleColor));
      TerritoryMapEntry.NativeFieldInfoPtr_InvisibleColor = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TerritoryMapEntry>.NativeClassPtr, nameof (InvisibleColor));
      TerritoryMapEntry.NativeFieldInfoPtr_PrevZoom = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TerritoryMapEntry>.NativeClassPtr, nameof (PrevZoom));
      TerritoryMapEntry.NativeFieldInfoPtr_PrevTextureIndex = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TerritoryMapEntry>.NativeClassPtr, nameof (PrevTextureIndex));
      TerritoryMapEntry.NativeFieldInfoPtr_PrevHovered = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TerritoryMapEntry>.NativeClassPtr, nameof (PrevHovered));
      TerritoryMapEntry.NativeFieldInfoPtr_HasInstancedMaterial = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TerritoryMapEntry>.NativeClassPtr, nameof (HasInstancedMaterial));
      TerritoryMapEntry.NativeFieldInfoPtr_RecentlyActivated = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TerritoryMapEntry>.NativeClassPtr, nameof (RecentlyActivated));
      TerritoryMapEntry.NativeFieldInfoPtr_MainTexID = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TerritoryMapEntry>.NativeClassPtr, nameof (MainTexID));
      TerritoryMapEntry.NativeFieldInfoPtr_RevealTextureID = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TerritoryMapEntry>.NativeClassPtr, nameof (RevealTextureID));
      TerritoryMapEntry.NativeFieldInfoPtr_MinXID = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TerritoryMapEntry>.NativeClassPtr, nameof (MinXID));
      TerritoryMapEntry.NativeFieldInfoPtr_MaxXID = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TerritoryMapEntry>.NativeClassPtr, nameof (MaxXID));
      TerritoryMapEntry.NativeFieldInfoPtr_MinZID = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TerritoryMapEntry>.NativeClassPtr, nameof (MinZID));
      TerritoryMapEntry.NativeFieldInfoPtr_MaxZID = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TerritoryMapEntry>.NativeClassPtr, nameof (MaxZID));
      TerritoryMapEntry.NativeFieldInfoPtr_TerritoryColorID = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TerritoryMapEntry>.NativeClassPtr, nameof (TerritoryColorID));
      TerritoryMapEntry.NativeFieldInfoPtr_InnerLineColorID = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TerritoryMapEntry>.NativeClassPtr, nameof (InnerLineColorID));
      TerritoryMapEntry.NativeFieldInfoPtr_OuterLineColorID = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TerritoryMapEntry>.NativeClassPtr, nameof (OuterLineColorID));
      TerritoryMapEntry.NativeFieldInfoPtr_EdgeThicknessID = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TerritoryMapEntry>.NativeClassPtr, nameof (EdgeThicknessID));
      TerritoryMapEntry.NativeMethodInfoPtr_OnEnable_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TerritoryMapEntry>.NativeClassPtr, 100668286);
      TerritoryMapEntry.NativeMethodInfoPtr_OnDisable_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TerritoryMapEntry>.NativeClassPtr, 100668287);
      TerritoryMapEntry.NativeMethodInfoPtr_HasDataChangedMainMap_Public_Boolean_LocalTerritoryTeamStatus_Int32_Boolean_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TerritoryMapEntry>.NativeClassPtr, 100668288);
      TerritoryMapEntry.NativeMethodInfoPtr_HasDataChangedMinimap_Public_Boolean_LocalTerritoryTeamStatus_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TerritoryMapEntry>.NativeClassPtr, 100668289);
      TerritoryMapEntry.NativeMethodInfoPtr_UpdatePosition_Public_Void_Vector2_Vector2_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TerritoryMapEntry>.NativeClassPtr, 100668290);
      TerritoryMapEntry.NativeMethodInfoPtr_SetData_Public_Void_Boolean_Int32_LocalTerritoryTeamStatus_Single_Boolean_Texture2D_Vector2_Single_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TerritoryMapEntry>.NativeClassPtr, 100668291);
      TerritoryMapEntry.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TerritoryMapEntry>.NativeClassPtr, 100668292);
    }

    public TerritoryMapEntry(IntPtr pointer)
      : base(pointer)
    {
    }

    public unsafe TerritoryTextureCollection TerritoryTextureCollection
    {
      get
      {
        IntPtr pointer = *(IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(TerritoryMapEntry.NativeFieldInfoPtr_TerritoryTextureCollection));
        return pointer == IntPtr.Zero ? (TerritoryTextureCollection) null : new TerritoryTextureCollection(pointer);
      }
      [param: In] set
      {
        IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(TerritoryMapEntry.NativeFieldInfoPtr_TerritoryTextureCollection), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe CastleTerritoryStateColorsAsset CastleTerritoryStateColors
    {
      get
      {
        IntPtr pointer = *(IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(TerritoryMapEntry.NativeFieldInfoPtr_CastleTerritoryStateColors));
        return pointer == IntPtr.Zero ? (CastleTerritoryStateColorsAsset) null : new CastleTerritoryStateColorsAsset(pointer);
      }
      [param: In] set
      {
        IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(TerritoryMapEntry.NativeFieldInfoPtr_CastleTerritoryStateColors), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe RectTransform RectTransform
    {
      get
      {
        IntPtr pointer = *(IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(TerritoryMapEntry.NativeFieldInfoPtr_RectTransform));
        return pointer == IntPtr.Zero ? (RectTransform) null : new RectTransform(pointer);
      }
      [param: In] set
      {
        IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(TerritoryMapEntry.NativeFieldInfoPtr_RectTransform), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe Image Image
    {
      get
      {
        IntPtr pointer = *(IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(TerritoryMapEntry.NativeFieldInfoPtr_Image));
        return pointer == IntPtr.Zero ? (Image) null : new Image(pointer);
      }
      [param: In] set
      {
        IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(TerritoryMapEntry.NativeFieldInfoPtr_Image), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe TerritoryMapEntry.LocalTerritoryTeamStatus PrevTerritoryTeam
    {
      get
      {
        return *(TerritoryMapEntry.LocalTerritoryTeamStatus*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(TerritoryMapEntry.NativeFieldInfoPtr_PrevTerritoryTeam));
      }
      [param: In] set
      {
        *(TerritoryMapEntry.LocalTerritoryTeamStatus*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(TerritoryMapEntry.NativeFieldInfoPtr_PrevTerritoryTeam)) = value;
      }
    }

    public static unsafe string MinimapKeywordID
    {
      get
      {
        IntPtr il2CppString;
        IL2CPP.il2cpp_field_static_get_value(TerritoryMapEntry.NativeFieldInfoPtr_MinimapKeywordID, (void*) &il2CppString);
        return IL2CPP.Il2CppStringToManaged(il2CppString);
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(TerritoryMapEntry.NativeFieldInfoPtr_MinimapKeywordID, (void*) IL2CPP.ManagedStringToIl2Cpp(value));
      }
    }

    public static unsafe Color VisibleColor
    {
      get
      {
        Color visibleColor;
        IL2CPP.il2cpp_field_static_get_value(TerritoryMapEntry.NativeFieldInfoPtr_VisibleColor, (void*) &visibleColor);
        return visibleColor;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(TerritoryMapEntry.NativeFieldInfoPtr_VisibleColor, (void*) &value);
      }
    }

    public static unsafe Color InvisibleColor
    {
      get
      {
        Color invisibleColor;
        IL2CPP.il2cpp_field_static_get_value(TerritoryMapEntry.NativeFieldInfoPtr_InvisibleColor, (void*) &invisibleColor);
        return invisibleColor;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(TerritoryMapEntry.NativeFieldInfoPtr_InvisibleColor, (void*) &value);
      }
    }

    public unsafe float PrevZoom
    {
      get
      {
        return *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(TerritoryMapEntry.NativeFieldInfoPtr_PrevZoom));
      }
      [param: In] set
      {
        *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(TerritoryMapEntry.NativeFieldInfoPtr_PrevZoom)) = value;
      }
    }

    public unsafe int PrevTextureIndex
    {
      get
      {
        return *(int*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(TerritoryMapEntry.NativeFieldInfoPtr_PrevTextureIndex));
      }
      [param: In] set
      {
        *(int*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(TerritoryMapEntry.NativeFieldInfoPtr_PrevTextureIndex)) = value;
      }
    }

    public unsafe bool PrevHovered
    {
      get
      {
        return *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(TerritoryMapEntry.NativeFieldInfoPtr_PrevHovered));
      }
      [param: In] set
      {
        *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(TerritoryMapEntry.NativeFieldInfoPtr_PrevHovered)) = value;
      }
    }

    public unsafe bool HasInstancedMaterial
    {
      get
      {
        return *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(TerritoryMapEntry.NativeFieldInfoPtr_HasInstancedMaterial));
      }
      [param: In] set
      {
        *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(TerritoryMapEntry.NativeFieldInfoPtr_HasInstancedMaterial)) = value;
      }
    }

    public unsafe bool RecentlyActivated
    {
      get
      {
        return *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(TerritoryMapEntry.NativeFieldInfoPtr_RecentlyActivated));
      }
      [param: In] set
      {
        *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(TerritoryMapEntry.NativeFieldInfoPtr_RecentlyActivated)) = value;
      }
    }

    public static unsafe int MainTexID
    {
      get
      {
        int mainTexId;
        IL2CPP.il2cpp_field_static_get_value(TerritoryMapEntry.NativeFieldInfoPtr_MainTexID, (void*) &mainTexId);
        return mainTexId;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(TerritoryMapEntry.NativeFieldInfoPtr_MainTexID, (void*) &value);
      }
    }

    public static unsafe int RevealTextureID
    {
      get
      {
        int revealTextureId;
        IL2CPP.il2cpp_field_static_get_value(TerritoryMapEntry.NativeFieldInfoPtr_RevealTextureID, (void*) &revealTextureId);
        return revealTextureId;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(TerritoryMapEntry.NativeFieldInfoPtr_RevealTextureID, (void*) &value);
      }
    }

    public static unsafe int MinXID
    {
      get
      {
        int minXid;
        IL2CPP.il2cpp_field_static_get_value(TerritoryMapEntry.NativeFieldInfoPtr_MinXID, (void*) &minXid);
        return minXid;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(TerritoryMapEntry.NativeFieldInfoPtr_MinXID, (void*) &value);
      }
    }

    public static unsafe int MaxXID
    {
      get
      {
        int maxXid;
        IL2CPP.il2cpp_field_static_get_value(TerritoryMapEntry.NativeFieldInfoPtr_MaxXID, (void*) &maxXid);
        return maxXid;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(TerritoryMapEntry.NativeFieldInfoPtr_MaxXID, (void*) &value);
      }
    }

    public static unsafe int MinZID
    {
      get
      {
        int minZid;
        IL2CPP.il2cpp_field_static_get_value(TerritoryMapEntry.NativeFieldInfoPtr_MinZID, (void*) &minZid);
        return minZid;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(TerritoryMapEntry.NativeFieldInfoPtr_MinZID, (void*) &value);
      }
    }

    public static unsafe int MaxZID
    {
      get
      {
        int maxZid;
        IL2CPP.il2cpp_field_static_get_value(TerritoryMapEntry.NativeFieldInfoPtr_MaxZID, (void*) &maxZid);
        return maxZid;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(TerritoryMapEntry.NativeFieldInfoPtr_MaxZID, (void*) &value);
      }
    }

    public static unsafe int TerritoryColorID
    {
      get
      {
        int territoryColorId;
        IL2CPP.il2cpp_field_static_get_value(TerritoryMapEntry.NativeFieldInfoPtr_TerritoryColorID, (void*) &territoryColorId);
        return territoryColorId;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(TerritoryMapEntry.NativeFieldInfoPtr_TerritoryColorID, (void*) &value);
      }
    }

    public static unsafe int InnerLineColorID
    {
      get
      {
        int innerLineColorId;
        IL2CPP.il2cpp_field_static_get_value(TerritoryMapEntry.NativeFieldInfoPtr_InnerLineColorID, (void*) &innerLineColorId);
        return innerLineColorId;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(TerritoryMapEntry.NativeFieldInfoPtr_InnerLineColorID, (void*) &value);
      }
    }

    public static unsafe int OuterLineColorID
    {
      get
      {
        int outerLineColorId;
        IL2CPP.il2cpp_field_static_get_value(TerritoryMapEntry.NativeFieldInfoPtr_OuterLineColorID, (void*) &outerLineColorId);
        return outerLineColorId;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(TerritoryMapEntry.NativeFieldInfoPtr_OuterLineColorID, (void*) &value);
      }
    }

    public static unsafe int EdgeThicknessID
    {
      get
      {
        int edgeThicknessId;
        IL2CPP.il2cpp_field_static_get_value(TerritoryMapEntry.NativeFieldInfoPtr_EdgeThicknessID, (void*) &edgeThicknessId);
        return edgeThicknessId;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(TerritoryMapEntry.NativeFieldInfoPtr_EdgeThicknessID, (void*) &value);
      }
    }

    public enum LocalTerritoryTeamStatus : byte
    {
      Neutral,
      Ally,
      Enemy,
      AllyDecay,
      EnemyDecay,
    }
  }
}
