// Decompiled with JetBrains decompiler
// Type: ProjectM.UI.MiniMapHUDParent
// Assembly: ProjectM.HUD, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 19DF27AB-2445-4ADB-A558-10C99A6E640A
// Assembly location: C:\Users\mitch\.nuget\packages\vrising.unhollowed.client\0.6.5.57575090\lib\net6.0\ProjectM.HUD.dll

using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using StunShared.UI;
using System;
using System.Runtime.InteropServices;
using UnityEngine;
using UnityEngine.UI;

#nullable disable
namespace ProjectM.UI
{
  public class MiniMapHUDParent : StunGUIBehaviour
  {
    private static readonly IntPtr NativeFieldInfoPtr_MapTexture;
    private static readonly IntPtr NativeFieldInfoPtr_CurseDebuffVisualization;
    private static readonly IntPtr NativeFieldInfoPtr_Compass;
    private static readonly IntPtr NativeFieldInfoPtr_CastleIconArray;
    private static readonly IntPtr NativeFieldInfoPtr_ZoomInButton;
    private static readonly IntPtr NativeFieldInfoPtr_ZoomOutButton;
    private static readonly IntPtr NativeFieldInfoPtr_ToggleMapRotationButton;
    private static readonly IntPtr NativeFieldInfoPtr_ToggleMapRotationImage;
    private static readonly IntPtr NativeFieldInfoPtr_MapZoneMarkerNode;
    private static readonly IntPtr NativeFieldInfoPtr_MapZoneAreaMarkerPrefab;
    private static readonly IntPtr NativeFieldInfoPtr_MapMarkerNode1;
    private static readonly IntPtr NativeFieldInfoPtr_TerritoryMarkerNode;
    private static readonly IntPtr NativeFieldInfoPtr_TerritoryMarkerPrefab;
    private static readonly IntPtr NativeFieldInfoPtr_MapMarkerPrefab;
    private static readonly IntPtr NativeFieldInfoPtr_MinimapMarkerPrefab;
    private static readonly IntPtr NativeFieldInfoPtr_ClampDist;
    private static readonly IntPtr NativeFieldInfoPtr_NonClampMaxDist;
    private static readonly IntPtr NativeFieldInfoPtr_Settings;
    private static readonly IntPtr NativeFieldInfoPtr_AllyColor;
    private static readonly IntPtr NativeFieldInfoPtr_NonAllyColor;
    private static readonly IntPtr NativeFieldInfoPtr_LocalPlayerIconPrefab;
    private static readonly IntPtr NativeFieldInfoPtr_LocalPlayerPathIconPrefab;
    private static readonly IntPtr NativeFieldInfoPtr__Initialized;
    private static readonly IntPtr NativeFieldInfoPtr__ButtonHovered;
    private static readonly IntPtr NativeFieldInfoPtr_TerritoryMarkerCache;
    private static readonly IntPtr NativeFieldInfoPtr__MapZoneAreaMarkerCache;
    private static readonly IntPtr NativeFieldInfoPtr_MinimapMarkerInstances;
    private static readonly IntPtr NativeMethodInfoPtr_get_AnyButtonHovered_Public_get_Boolean_0;
    private static readonly IntPtr NativeMethodInfoPtr_get_MapZoneAreaMarkerCache_Public_get_UI_Cache_1_MapZoneAreaMarker_0;
    private static readonly IntPtr NativeMethodInfoPtr_Initialize_Public_Void_0;
    private static readonly IntPtr NativeMethodInfoPtr_ButtonPointerEnter_Public_Void_0;
    private static readonly IntPtr NativeMethodInfoPtr_ButtonPointerExit_Public_Void_0;
    private static readonly IntPtr NativeMethodInfoPtr_GetCastleSprite_Internal_Sprite_Int32_0;
    private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

    public unsafe bool AnyButtonHovered
    {
      [CallerCount(0)] get
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IntPtr* numPtr = (IntPtr*) null;
        IntPtr exc;
        IntPtr num = IL2CPP.il2cpp_runtime_invoke(MiniMapHUDParent.NativeMethodInfoPtr_get_AnyButtonHovered_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
        return *(bool*) IL2CPP.il2cpp_object_unbox(num);
      }
    }

    public unsafe UI_Cache<MapZoneAreaMarker> MapZoneAreaMarkerCache
    {
      [CallerCount(0)] get
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IntPtr* numPtr = (IntPtr*) null;
        IntPtr exc;
        IntPtr num = IL2CPP.il2cpp_runtime_invoke(MiniMapHUDParent.NativeMethodInfoPtr_get_MapZoneAreaMarkerCache_Public_get_UI_Cache_1_MapZoneAreaMarker_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
        IntPtr pointer = num;
        return pointer == IntPtr.Zero ? (UI_Cache<MapZoneAreaMarker>) null : new UI_Cache<MapZoneAreaMarker>(pointer);
      }
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1271611, XrefRangeEnd = 1271625, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe void Initialize()
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IntPtr* numPtr = (IntPtr*) null;
      IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(MiniMapHUDParent.NativeMethodInfoPtr_Initialize_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    public unsafe void ButtonPointerEnter()
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IntPtr* numPtr = (IntPtr*) null;
      IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(MiniMapHUDParent.NativeMethodInfoPtr_ButtonPointerEnter_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    public unsafe void ButtonPointerExit()
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IntPtr* numPtr = (IntPtr*) null;
      IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(MiniMapHUDParent.NativeMethodInfoPtr_ButtonPointerExit_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    public unsafe Sprite GetCastleSprite(int id)
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IntPtr* numPtr = stackalloc IntPtr[1];
      numPtr[0] = (IntPtr) &id;
      IntPtr exc;
      IntPtr num = IL2CPP.il2cpp_runtime_invoke(MiniMapHUDParent.NativeMethodInfoPtr_GetCastleSprite_Internal_Sprite_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      IntPtr pointer = num;
      return pointer == IntPtr.Zero ? (Sprite) null : new Sprite(pointer);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1271625, XrefRangeEnd = 1271633, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe MiniMapHUDParent()
      : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<MiniMapHUDParent>.NativeClassPtr))
    {
      IntPtr* numPtr = (IntPtr*) null;
      IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(MiniMapHUDParent.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    static MiniMapHUDParent()
    {
      Il2CppClassPointerStore<MiniMapHUDParent>.NativeClassPtr = IL2CPP.GetIl2CppClass("ProjectM.HUD.dll", "ProjectM.UI", nameof (MiniMapHUDParent));
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<MiniMapHUDParent>.NativeClassPtr);
      MiniMapHUDParent.NativeFieldInfoPtr_MapTexture = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MiniMapHUDParent>.NativeClassPtr, nameof (MapTexture));
      MiniMapHUDParent.NativeFieldInfoPtr_CurseDebuffVisualization = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MiniMapHUDParent>.NativeClassPtr, nameof (CurseDebuffVisualization));
      MiniMapHUDParent.NativeFieldInfoPtr_Compass = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MiniMapHUDParent>.NativeClassPtr, nameof (Compass));
      MiniMapHUDParent.NativeFieldInfoPtr_CastleIconArray = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MiniMapHUDParent>.NativeClassPtr, nameof (CastleIconArray));
      MiniMapHUDParent.NativeFieldInfoPtr_ZoomInButton = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MiniMapHUDParent>.NativeClassPtr, nameof (ZoomInButton));
      MiniMapHUDParent.NativeFieldInfoPtr_ZoomOutButton = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MiniMapHUDParent>.NativeClassPtr, nameof (ZoomOutButton));
      MiniMapHUDParent.NativeFieldInfoPtr_ToggleMapRotationButton = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MiniMapHUDParent>.NativeClassPtr, nameof (ToggleMapRotationButton));
      MiniMapHUDParent.NativeFieldInfoPtr_ToggleMapRotationImage = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MiniMapHUDParent>.NativeClassPtr, nameof (ToggleMapRotationImage));
      MiniMapHUDParent.NativeFieldInfoPtr_MapZoneMarkerNode = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MiniMapHUDParent>.NativeClassPtr, nameof (MapZoneMarkerNode));
      MiniMapHUDParent.NativeFieldInfoPtr_MapZoneAreaMarkerPrefab = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MiniMapHUDParent>.NativeClassPtr, nameof (MapZoneAreaMarkerPrefab));
      MiniMapHUDParent.NativeFieldInfoPtr_MapMarkerNode1 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MiniMapHUDParent>.NativeClassPtr, nameof (MapMarkerNode1));
      MiniMapHUDParent.NativeFieldInfoPtr_TerritoryMarkerNode = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MiniMapHUDParent>.NativeClassPtr, nameof (TerritoryMarkerNode));
      MiniMapHUDParent.NativeFieldInfoPtr_TerritoryMarkerPrefab = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MiniMapHUDParent>.NativeClassPtr, nameof (TerritoryMarkerPrefab));
      MiniMapHUDParent.NativeFieldInfoPtr_MapMarkerPrefab = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MiniMapHUDParent>.NativeClassPtr, nameof (MapMarkerPrefab));
      MiniMapHUDParent.NativeFieldInfoPtr_MinimapMarkerPrefab = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MiniMapHUDParent>.NativeClassPtr, nameof (MinimapMarkerPrefab));
      MiniMapHUDParent.NativeFieldInfoPtr_ClampDist = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MiniMapHUDParent>.NativeClassPtr, nameof (ClampDist));
      MiniMapHUDParent.NativeFieldInfoPtr_NonClampMaxDist = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MiniMapHUDParent>.NativeClassPtr, nameof (NonClampMaxDist));
      MiniMapHUDParent.NativeFieldInfoPtr_Settings = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MiniMapHUDParent>.NativeClassPtr, nameof (Settings));
      MiniMapHUDParent.NativeFieldInfoPtr_AllyColor = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MiniMapHUDParent>.NativeClassPtr, nameof (AllyColor));
      MiniMapHUDParent.NativeFieldInfoPtr_NonAllyColor = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MiniMapHUDParent>.NativeClassPtr, nameof (NonAllyColor));
      MiniMapHUDParent.NativeFieldInfoPtr_LocalPlayerIconPrefab = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MiniMapHUDParent>.NativeClassPtr, nameof (LocalPlayerIconPrefab));
      MiniMapHUDParent.NativeFieldInfoPtr_LocalPlayerPathIconPrefab = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MiniMapHUDParent>.NativeClassPtr, nameof (LocalPlayerPathIconPrefab));
      MiniMapHUDParent.NativeFieldInfoPtr__Initialized = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MiniMapHUDParent>.NativeClassPtr, nameof (_Initialized));
      MiniMapHUDParent.NativeFieldInfoPtr__ButtonHovered = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MiniMapHUDParent>.NativeClassPtr, nameof (_ButtonHovered));
      MiniMapHUDParent.NativeFieldInfoPtr_TerritoryMarkerCache = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MiniMapHUDParent>.NativeClassPtr, nameof (TerritoryMarkerCache));
      MiniMapHUDParent.NativeFieldInfoPtr__MapZoneAreaMarkerCache = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MiniMapHUDParent>.NativeClassPtr, nameof (_MapZoneAreaMarkerCache));
      MiniMapHUDParent.NativeFieldInfoPtr_MinimapMarkerInstances = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MiniMapHUDParent>.NativeClassPtr, nameof (MinimapMarkerInstances));
      MiniMapHUDParent.NativeMethodInfoPtr_get_AnyButtonHovered_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MiniMapHUDParent>.NativeClassPtr, 100668062);
      MiniMapHUDParent.NativeMethodInfoPtr_get_MapZoneAreaMarkerCache_Public_get_UI_Cache_1_MapZoneAreaMarker_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MiniMapHUDParent>.NativeClassPtr, 100668063);
      MiniMapHUDParent.NativeMethodInfoPtr_Initialize_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MiniMapHUDParent>.NativeClassPtr, 100668064);
      MiniMapHUDParent.NativeMethodInfoPtr_ButtonPointerEnter_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MiniMapHUDParent>.NativeClassPtr, 100668065);
      MiniMapHUDParent.NativeMethodInfoPtr_ButtonPointerExit_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MiniMapHUDParent>.NativeClassPtr, 100668066);
      MiniMapHUDParent.NativeMethodInfoPtr_GetCastleSprite_Internal_Sprite_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MiniMapHUDParent>.NativeClassPtr, 100668067);
      MiniMapHUDParent.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MiniMapHUDParent>.NativeClassPtr, 100668068);
    }

    public MiniMapHUDParent(IntPtr pointer)
      : base(pointer)
    {
    }

    public unsafe RawImage MapTexture
    {
      get
      {
        IntPtr pointer = *(IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(MiniMapHUDParent.NativeFieldInfoPtr_MapTexture));
        return pointer == IntPtr.Zero ? (RawImage) null : new RawImage(pointer);
      }
      [param: In] set
      {
        IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(MiniMapHUDParent.NativeFieldInfoPtr_MapTexture), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe RawImage CurseDebuffVisualization
    {
      get
      {
        IntPtr pointer = *(IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(MiniMapHUDParent.NativeFieldInfoPtr_CurseDebuffVisualization));
        return pointer == IntPtr.Zero ? (RawImage) null : new RawImage(pointer);
      }
      [param: In] set
      {
        IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(MiniMapHUDParent.NativeFieldInfoPtr_CurseDebuffVisualization), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe MinimapCompass Compass
    {
      get
      {
        IntPtr pointer = *(IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(MiniMapHUDParent.NativeFieldInfoPtr_Compass));
        return pointer == IntPtr.Zero ? (MinimapCompass) null : new MinimapCompass(pointer);
      }
      [param: In] set
      {
        IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(MiniMapHUDParent.NativeFieldInfoPtr_Compass), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe Il2CppReferenceArray<Sprite> CastleIconArray
    {
      get
      {
        IntPtr nativeObject = *(IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(MiniMapHUDParent.NativeFieldInfoPtr_CastleIconArray));
        return nativeObject == IntPtr.Zero ? (Il2CppReferenceArray<Sprite>) null : new Il2CppReferenceArray<Sprite>(nativeObject);
      }
      [param: In] set
      {
        IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(MiniMapHUDParent.NativeFieldInfoPtr_CastleIconArray), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe Button ZoomInButton
    {
      get
      {
        IntPtr pointer = *(IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(MiniMapHUDParent.NativeFieldInfoPtr_ZoomInButton));
        return pointer == IntPtr.Zero ? (Button) null : new Button(pointer);
      }
      [param: In] set
      {
        IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(MiniMapHUDParent.NativeFieldInfoPtr_ZoomInButton), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe Button ZoomOutButton
    {
      get
      {
        IntPtr pointer = *(IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(MiniMapHUDParent.NativeFieldInfoPtr_ZoomOutButton));
        return pointer == IntPtr.Zero ? (Button) null : new Button(pointer);
      }
      [param: In] set
      {
        IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(MiniMapHUDParent.NativeFieldInfoPtr_ZoomOutButton), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe Button ToggleMapRotationButton
    {
      get
      {
        IntPtr pointer = *(IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(MiniMapHUDParent.NativeFieldInfoPtr_ToggleMapRotationButton));
        return pointer == IntPtr.Zero ? (Button) null : new Button(pointer);
      }
      [param: In] set
      {
        IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(MiniMapHUDParent.NativeFieldInfoPtr_ToggleMapRotationButton), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe Image ToggleMapRotationImage
    {
      get
      {
        IntPtr pointer = *(IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(MiniMapHUDParent.NativeFieldInfoPtr_ToggleMapRotationImage));
        return pointer == IntPtr.Zero ? (Image) null : new Image(pointer);
      }
      [param: In] set
      {
        IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(MiniMapHUDParent.NativeFieldInfoPtr_ToggleMapRotationImage), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe RectTransform MapZoneMarkerNode
    {
      get
      {
        IntPtr pointer = *(IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(MiniMapHUDParent.NativeFieldInfoPtr_MapZoneMarkerNode));
        return pointer == IntPtr.Zero ? (RectTransform) null : new RectTransform(pointer);
      }
      [param: In] set
      {
        IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(MiniMapHUDParent.NativeFieldInfoPtr_MapZoneMarkerNode), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe MapZoneAreaMarker MapZoneAreaMarkerPrefab
    {
      get
      {
        IntPtr pointer = *(IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(MiniMapHUDParent.NativeFieldInfoPtr_MapZoneAreaMarkerPrefab));
        return pointer == IntPtr.Zero ? (MapZoneAreaMarker) null : new MapZoneAreaMarker(pointer);
      }
      [param: In] set
      {
        IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(MiniMapHUDParent.NativeFieldInfoPtr_MapZoneAreaMarkerPrefab), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe RectTransform MapMarkerNode1
    {
      get
      {
        IntPtr pointer = *(IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(MiniMapHUDParent.NativeFieldInfoPtr_MapMarkerNode1));
        return pointer == IntPtr.Zero ? (RectTransform) null : new RectTransform(pointer);
      }
      [param: In] set
      {
        IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(MiniMapHUDParent.NativeFieldInfoPtr_MapMarkerNode1), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe RectTransform TerritoryMarkerNode
    {
      get
      {
        IntPtr pointer = *(IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(MiniMapHUDParent.NativeFieldInfoPtr_TerritoryMarkerNode));
        return pointer == IntPtr.Zero ? (RectTransform) null : new RectTransform(pointer);
      }
      [param: In] set
      {
        IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(MiniMapHUDParent.NativeFieldInfoPtr_TerritoryMarkerNode), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe TerritoryMapEntry TerritoryMarkerPrefab
    {
      get
      {
        IntPtr pointer = *(IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(MiniMapHUDParent.NativeFieldInfoPtr_TerritoryMarkerPrefab));
        return pointer == IntPtr.Zero ? (TerritoryMapEntry) null : new TerritoryMapEntry(pointer);
      }
      [param: In] set
      {
        IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(MiniMapHUDParent.NativeFieldInfoPtr_TerritoryMarkerPrefab), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe MapMarker MapMarkerPrefab
    {
      get
      {
        IntPtr pointer = *(IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(MiniMapHUDParent.NativeFieldInfoPtr_MapMarkerPrefab));
        return pointer == IntPtr.Zero ? (MapMarker) null : new MapMarker(pointer);
      }
      [param: In] set
      {
        IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(MiniMapHUDParent.NativeFieldInfoPtr_MapMarkerPrefab), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe Image MinimapMarkerPrefab
    {
      get
      {
        IntPtr pointer = *(IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(MiniMapHUDParent.NativeFieldInfoPtr_MinimapMarkerPrefab));
        return pointer == IntPtr.Zero ? (Image) null : new Image(pointer);
      }
      [param: In] set
      {
        IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(MiniMapHUDParent.NativeFieldInfoPtr_MinimapMarkerPrefab), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe float ClampDist
    {
      get
      {
        return *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(MiniMapHUDParent.NativeFieldInfoPtr_ClampDist));
      }
      [param: In] set
      {
        *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(MiniMapHUDParent.NativeFieldInfoPtr_ClampDist)) = value;
      }
    }

    public unsafe float NonClampMaxDist
    {
      get
      {
        return *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(MiniMapHUDParent.NativeFieldInfoPtr_NonClampMaxDist));
      }
      [param: In] set
      {
        *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(MiniMapHUDParent.NativeFieldInfoPtr_NonClampMaxDist)) = value;
      }
    }

    public unsafe MapSettings Settings
    {
      get
      {
        IntPtr pointer = *(IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(MiniMapHUDParent.NativeFieldInfoPtr_Settings));
        return pointer == IntPtr.Zero ? (MapSettings) null : new MapSettings(pointer);
      }
      [param: In] set
      {
        IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(MiniMapHUDParent.NativeFieldInfoPtr_Settings), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe ColorAsset AllyColor
    {
      get
      {
        IntPtr pointer = *(IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(MiniMapHUDParent.NativeFieldInfoPtr_AllyColor));
        return pointer == IntPtr.Zero ? (ColorAsset) null : new ColorAsset(pointer);
      }
      [param: In] set
      {
        IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(MiniMapHUDParent.NativeFieldInfoPtr_AllyColor), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe ColorAsset NonAllyColor
    {
      get
      {
        IntPtr pointer = *(IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(MiniMapHUDParent.NativeFieldInfoPtr_NonAllyColor));
        return pointer == IntPtr.Zero ? (ColorAsset) null : new ColorAsset(pointer);
      }
      [param: In] set
      {
        IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(MiniMapHUDParent.NativeFieldInfoPtr_NonAllyColor), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe WeakAssetReference<MapIconAuthoring> LocalPlayerIconPrefab
    {
      get
      {
        IntPtr pointer = *(IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(MiniMapHUDParent.NativeFieldInfoPtr_LocalPlayerIconPrefab));
        return pointer == IntPtr.Zero ? (WeakAssetReference<MapIconAuthoring>) null : new WeakAssetReference<MapIconAuthoring>(pointer);
      }
      [param: In] set
      {
        IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(MiniMapHUDParent.NativeFieldInfoPtr_LocalPlayerIconPrefab), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe WeakAssetReference<MapIconAuthoring> LocalPlayerPathIconPrefab
    {
      get
      {
        IntPtr pointer = *(IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(MiniMapHUDParent.NativeFieldInfoPtr_LocalPlayerPathIconPrefab));
        return pointer == IntPtr.Zero ? (WeakAssetReference<MapIconAuthoring>) null : new WeakAssetReference<MapIconAuthoring>(pointer);
      }
      [param: In] set
      {
        IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(MiniMapHUDParent.NativeFieldInfoPtr_LocalPlayerPathIconPrefab), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe bool _Initialized
    {
      get
      {
        return *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(MiniMapHUDParent.NativeFieldInfoPtr__Initialized));
      }
      [param: In] set
      {
        *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(MiniMapHUDParent.NativeFieldInfoPtr__Initialized)) = value;
      }
    }

    public unsafe bool _ButtonHovered
    {
      get
      {
        return *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(MiniMapHUDParent.NativeFieldInfoPtr__ButtonHovered));
      }
      [param: In] set
      {
        *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(MiniMapHUDParent.NativeFieldInfoPtr__ButtonHovered)) = value;
      }
    }

    public unsafe UI_Cache<TerritoryMapEntry> TerritoryMarkerCache
    {
      get
      {
        IntPtr pointer = *(IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(MiniMapHUDParent.NativeFieldInfoPtr_TerritoryMarkerCache));
        return pointer == IntPtr.Zero ? (UI_Cache<TerritoryMapEntry>) null : new UI_Cache<TerritoryMapEntry>(pointer);
      }
      [param: In] set
      {
        IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(MiniMapHUDParent.NativeFieldInfoPtr_TerritoryMarkerCache), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe UI_Cache<MapZoneAreaMarker> _MapZoneAreaMarkerCache
    {
      get
      {
        IntPtr pointer = *(IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(MiniMapHUDParent.NativeFieldInfoPtr__MapZoneAreaMarkerCache));
        return pointer == IntPtr.Zero ? (UI_Cache<MapZoneAreaMarker>) null : new UI_Cache<MapZoneAreaMarker>(pointer);
      }
      [param: In] set
      {
        IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(MiniMapHUDParent.NativeFieldInfoPtr__MapZoneAreaMarkerCache), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe StructList<MinimapIconInstance> MinimapMarkerInstances
    {
      get
      {
        IntPtr pointer = *(IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(MiniMapHUDParent.NativeFieldInfoPtr_MinimapMarkerInstances));
        return pointer == IntPtr.Zero ? (StructList<MinimapIconInstance>) null : new StructList<MinimapIconInstance>(pointer);
      }
      [param: In] set
      {
        IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(MiniMapHUDParent.NativeFieldInfoPtr_MinimapMarkerInstances), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }
  }
}
