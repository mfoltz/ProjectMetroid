// Decompiled with JetBrains decompiler
// Type: ProjectM.StunDebug.DebugDrawComponent
// Assembly: ProjectM.Shared, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: CF03A298-FF93-4294-AFD6-565AD334A53C
// Assembly location: C:\Users\mitch\.nuget\packages\vrising.unhollowed.client\0.6.5.57575090\lib\net6.0\ProjectM.Shared.dll

using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppSystem;
using Il2CppSystem.Collections.Generic;
using System.Runtime.InteropServices;
using UnityEngine;

#nullable disable
namespace ProjectM.StunDebug
{
  public class DebugDrawComponent : MonoBehaviour
  {
    private static readonly System.IntPtr NativeFieldInfoPtr__ActiveTags;
    private static readonly System.IntPtr NativeFieldInfoPtr__ExistingTags;
    private static readonly System.IntPtr NativeFieldInfoPtr__Widgets;
    private static readonly System.IntPtr NativeFieldInfoPtr__RemoveList;
    private static readonly System.IntPtr NativeFieldInfoPtr__ModelDrawer;
    private static readonly System.IntPtr NativeFieldInfoPtr__HudDrawer;
    private static readonly System.IntPtr NativeFieldInfoPtr_ShowAllTags;
    private static readonly System.IntPtr NativeFieldInfoPtr_Active;
    private static readonly System.IntPtr NativeFieldInfoPtr_TimeoutDuration;
    private static readonly System.IntPtr NativeMethodInfoPtr_GetWidget_Public_DebugWidget_String_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_SetTagActive_Public_Void_String_Boolean_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_GetTags_Public_IEnumerable_1_String_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_GetActiveTags_Public_IEnumerable_1_String_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_RegisterTag_Public_Void_String_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_IsTagActive_Public_Boolean_String_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_AddWidget_Public_Boolean_String_DebugWidget_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_OnGUI_Private_Void_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_Start_Private_Void_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_Update_Private_Void_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_LateUpdate_Private_Void_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_OnPostRender_Private_Void_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_CheckInactiveWidgets_Internal_Void_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_IsWidgetActive_Public_Boolean_String_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_DrawSphere_Public_Void_Vector3_Single_Color_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_DrawCube_Public_Void_Vector3_Vector3_Color_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_DrawString_Public_Void_Vector3_String_Color_ViewSpace_Int32_Nullable_Unboxed_1_Vector2_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_DrawStringOneShot_Public_Void_Vector3_Vector3_String_Color_Single_ViewSpace_Int32_Nullable_Unboxed_1_Vector2_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_OnDisable_Private_Void_0;
    private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

    [CallerCount(3)]
    [CachedScanResults(RefRangeStart = 770927, RefRangeEnd = 770930, XrefRangeStart = 770923, XrefRangeEnd = 770927, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe DebugWidget GetWidget(string name)
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = stackalloc System.IntPtr[1];
      numPtr[0] = IL2CPP.ManagedStringToIl2Cpp(name);
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(DebugDrawComponent.NativeMethodInfoPtr_GetWidget_Public_DebugWidget_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      System.IntPtr pointer = num;
      return pointer == System.IntPtr.Zero ? (DebugWidget) null : new DebugWidget(pointer);
    }

    [CallerCount(1)]
    [CachedScanResults(RefRangeStart = 770940, RefRangeEnd = 770941, XrefRangeStart = 770930, XrefRangeEnd = 770940, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe void SetTagActive(string tag, bool active)
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = stackalloc System.IntPtr[2];
      numPtr[0] = IL2CPP.ManagedStringToIl2Cpp(tag);
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &active;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(DebugDrawComponent.NativeMethodInfoPtr_SetTagActive_Public_Void_String_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    public unsafe IEnumerable<string> GetTags()
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(DebugDrawComponent.NativeMethodInfoPtr_GetTags_Public_IEnumerable_1_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      System.IntPtr pointer = num;
      return pointer == System.IntPtr.Zero ? (IEnumerable<string>) null : new IEnumerable<string>(pointer);
    }

    [CallerCount(9)]
    [CachedScanResults(RefRangeStart = 16432, RefRangeEnd = 16441, XrefRangeStart = 16432, XrefRangeEnd = 16441, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe IEnumerable<string> GetActiveTags()
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(DebugDrawComponent.NativeMethodInfoPtr_GetActiveTags_Public_IEnumerable_1_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      System.IntPtr pointer = num;
      return pointer == System.IntPtr.Zero ? (IEnumerable<string>) null : new IEnumerable<string>(pointer);
    }

    [CallerCount(1)]
    [CachedScanResults(RefRangeStart = 770948, RefRangeEnd = 770949, XrefRangeStart = 770941, XrefRangeEnd = 770948, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe void RegisterTag(string tag)
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = stackalloc System.IntPtr[1];
      numPtr[0] = IL2CPP.ManagedStringToIl2Cpp(tag);
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(DebugDrawComponent.NativeMethodInfoPtr_RegisterTag_Public_Void_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 770949, XrefRangeEnd = 770956, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe bool IsTagActive(string tag)
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = stackalloc System.IntPtr[1];
      numPtr[0] = IL2CPP.ManagedStringToIl2Cpp(tag);
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(DebugDrawComponent.NativeMethodInfoPtr_IsTagActive_Public_Boolean_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(bool*) IL2CPP.il2cpp_object_unbox(num);
    }

    [CallerCount(3)]
    [CachedScanResults(RefRangeStart = 770960, RefRangeEnd = 770963, XrefRangeStart = 770956, XrefRangeEnd = 770960, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe bool AddWidget(string name, DebugWidget widget)
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = stackalloc System.IntPtr[2];
      numPtr[0] = IL2CPP.ManagedStringToIl2Cpp(name);
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) widget);
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(DebugDrawComponent.NativeMethodInfoPtr_AddWidget_Public_Boolean_String_DebugWidget_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(bool*) IL2CPP.il2cpp_object_unbox(num);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 770963, XrefRangeEnd = 770984, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe void OnGUI()
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(DebugDrawComponent.NativeMethodInfoPtr_OnGUI_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(10560)]
    [CachedScanResults(RefRangeStart = 24, RefRangeEnd = 10584, XrefRangeStart = 24, XrefRangeEnd = 10584, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe void Start()
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(DebugDrawComponent.NativeMethodInfoPtr_Start_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(10560)]
    [CachedScanResults(RefRangeStart = 24, RefRangeEnd = 10584, XrefRangeStart = 24, XrefRangeEnd = 10584, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe void Update()
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(DebugDrawComponent.NativeMethodInfoPtr_Update_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 770984, XrefRangeEnd = 771002, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe void LateUpdate()
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(DebugDrawComponent.NativeMethodInfoPtr_LateUpdate_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 771002, XrefRangeEnd = 771004, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe void OnPostRender()
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(DebugDrawComponent.NativeMethodInfoPtr_OnPostRender_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(1)]
    [CachedScanResults(RefRangeStart = 771044, RefRangeEnd = 771045, XrefRangeStart = 771004, XrefRangeEnd = 771044, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe void CheckInactiveWidgets()
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(DebugDrawComponent.NativeMethodInfoPtr_CheckInactiveWidgets_Internal_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(2)]
    [CachedScanResults(RefRangeStart = 771049, RefRangeEnd = 771051, XrefRangeStart = 771045, XrefRangeEnd = 771049, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe bool IsWidgetActive(string name)
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = stackalloc System.IntPtr[1];
      numPtr[0] = IL2CPP.ManagedStringToIl2Cpp(name);
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(DebugDrawComponent.NativeMethodInfoPtr_IsWidgetActive_Public_Boolean_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(bool*) IL2CPP.il2cpp_object_unbox(num);
    }

    [CallerCount(1)]
    [CachedScanResults(RefRangeStart = 771052, RefRangeEnd = 771053, XrefRangeStart = 771051, XrefRangeEnd = 771052, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe void DrawSphere(Vector3 position, float radius, Color color)
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = stackalloc System.IntPtr[3];
      numPtr[0] = (System.IntPtr) &position;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &radius;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = (System.IntPtr) &color;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(DebugDrawComponent.NativeMethodInfoPtr_DrawSphere_Public_Void_Vector3_Single_Color_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(1)]
    [CachedScanResults(RefRangeStart = 771054, RefRangeEnd = 771055, XrefRangeStart = 771053, XrefRangeEnd = 771054, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe void DrawCube(Vector3 position, Vector3 scale, Color color)
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = stackalloc System.IntPtr[3];
      numPtr[0] = (System.IntPtr) &position;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &scale;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = (System.IntPtr) &color;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(DebugDrawComponent.NativeMethodInfoPtr_DrawCube_Public_Void_Vector3_Vector3_Color_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(1)]
    [CachedScanResults(RefRangeStart = 771056, RefRangeEnd = 771057, XrefRangeStart = 771055, XrefRangeEnd = 771056, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe void DrawString(
      Vector3 position,
      string text,
      Color color,
      HudDrawer.ViewSpace viewSpace,
      int fontSize = 20,
      Nullable_Unboxed<Vector2> pivot = default (Nullable_Unboxed<Vector2>))
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = stackalloc System.IntPtr[6];
      numPtr[0] = (System.IntPtr) &position;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = IL2CPP.ManagedStringToIl2Cpp(text);
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = (System.IntPtr) &color;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(3) * sizeof (System.IntPtr))) = (System.IntPtr) &viewSpace;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(4) * sizeof (System.IntPtr))) = (System.IntPtr) &fontSize;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(5) * sizeof (System.IntPtr))) = (System.IntPtr) &pivot;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(DebugDrawComponent.NativeMethodInfoPtr_DrawString_Public_Void_Vector3_String_Color_ViewSpace_Int32_Nullable_Unboxed_1_Vector2_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(2)]
    [CachedScanResults(RefRangeStart = 771058, RefRangeEnd = 771060, XrefRangeStart = 771057, XrefRangeEnd = 771058, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe void DrawStringOneShot(
      Vector3 position,
      Vector3 velocity,
      string text,
      Color color,
      float lifetime,
      HudDrawer.ViewSpace viewSpace,
      int fontSize = 20,
      Nullable_Unboxed<Vector2> pivot = default (Nullable_Unboxed<Vector2>))
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = stackalloc System.IntPtr[8];
      numPtr[0] = (System.IntPtr) &position;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &velocity;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = IL2CPP.ManagedStringToIl2Cpp(text);
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(3) * sizeof (System.IntPtr))) = (System.IntPtr) &color;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(4) * sizeof (System.IntPtr))) = (System.IntPtr) &lifetime;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(5) * sizeof (System.IntPtr))) = (System.IntPtr) &viewSpace;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(6) * sizeof (System.IntPtr))) = (System.IntPtr) &fontSize;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(7) * sizeof (System.IntPtr))) = (System.IntPtr) &pivot;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(DebugDrawComponent.NativeMethodInfoPtr_DrawStringOneShot_Public_Void_Vector3_Vector3_String_Color_Single_ViewSpace_Int32_Nullable_Unboxed_1_Vector2_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(10560)]
    [CachedScanResults(RefRangeStart = 24, RefRangeEnd = 10584, XrefRangeStart = 24, XrefRangeEnd = 10584, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe void OnDisable()
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(DebugDrawComponent.NativeMethodInfoPtr_OnDisable_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 771060, XrefRangeEnd = 771109, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe DebugDrawComponent()
      : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<DebugDrawComponent>.NativeClassPtr))
    {
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(DebugDrawComponent.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    static DebugDrawComponent()
    {
      Il2CppClassPointerStore<DebugDrawComponent>.NativeClassPtr = IL2CPP.GetIl2CppClass("ProjectM.Shared.dll", "ProjectM.StunDebug", nameof (DebugDrawComponent));
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<DebugDrawComponent>.NativeClassPtr);
      DebugDrawComponent.NativeFieldInfoPtr__ActiveTags = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DebugDrawComponent>.NativeClassPtr, nameof (_ActiveTags));
      DebugDrawComponent.NativeFieldInfoPtr__ExistingTags = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DebugDrawComponent>.NativeClassPtr, nameof (_ExistingTags));
      DebugDrawComponent.NativeFieldInfoPtr__Widgets = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DebugDrawComponent>.NativeClassPtr, nameof (_Widgets));
      DebugDrawComponent.NativeFieldInfoPtr__RemoveList = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DebugDrawComponent>.NativeClassPtr, nameof (_RemoveList));
      DebugDrawComponent.NativeFieldInfoPtr__ModelDrawer = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DebugDrawComponent>.NativeClassPtr, nameof (_ModelDrawer));
      DebugDrawComponent.NativeFieldInfoPtr__HudDrawer = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DebugDrawComponent>.NativeClassPtr, nameof (_HudDrawer));
      DebugDrawComponent.NativeFieldInfoPtr_ShowAllTags = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DebugDrawComponent>.NativeClassPtr, nameof (ShowAllTags));
      DebugDrawComponent.NativeFieldInfoPtr_Active = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DebugDrawComponent>.NativeClassPtr, nameof (Active));
      DebugDrawComponent.NativeFieldInfoPtr_TimeoutDuration = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DebugDrawComponent>.NativeClassPtr, nameof (TimeoutDuration));
      DebugDrawComponent.NativeMethodInfoPtr_GetWidget_Public_DebugWidget_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DebugDrawComponent>.NativeClassPtr, 100668297);
      DebugDrawComponent.NativeMethodInfoPtr_SetTagActive_Public_Void_String_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DebugDrawComponent>.NativeClassPtr, 100668298);
      DebugDrawComponent.NativeMethodInfoPtr_GetTags_Public_IEnumerable_1_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DebugDrawComponent>.NativeClassPtr, 100668299);
      DebugDrawComponent.NativeMethodInfoPtr_GetActiveTags_Public_IEnumerable_1_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DebugDrawComponent>.NativeClassPtr, 100668300);
      DebugDrawComponent.NativeMethodInfoPtr_RegisterTag_Public_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DebugDrawComponent>.NativeClassPtr, 100668301);
      DebugDrawComponent.NativeMethodInfoPtr_IsTagActive_Public_Boolean_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DebugDrawComponent>.NativeClassPtr, 100668302);
      DebugDrawComponent.NativeMethodInfoPtr_AddWidget_Public_Boolean_String_DebugWidget_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DebugDrawComponent>.NativeClassPtr, 100668303);
      DebugDrawComponent.NativeMethodInfoPtr_OnGUI_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DebugDrawComponent>.NativeClassPtr, 100668304);
      DebugDrawComponent.NativeMethodInfoPtr_Start_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DebugDrawComponent>.NativeClassPtr, 100668305);
      DebugDrawComponent.NativeMethodInfoPtr_Update_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DebugDrawComponent>.NativeClassPtr, 100668306);
      DebugDrawComponent.NativeMethodInfoPtr_LateUpdate_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DebugDrawComponent>.NativeClassPtr, 100668307);
      DebugDrawComponent.NativeMethodInfoPtr_OnPostRender_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DebugDrawComponent>.NativeClassPtr, 100668308);
      DebugDrawComponent.NativeMethodInfoPtr_CheckInactiveWidgets_Internal_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DebugDrawComponent>.NativeClassPtr, 100668309);
      DebugDrawComponent.NativeMethodInfoPtr_IsWidgetActive_Public_Boolean_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DebugDrawComponent>.NativeClassPtr, 100668310);
      DebugDrawComponent.NativeMethodInfoPtr_DrawSphere_Public_Void_Vector3_Single_Color_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DebugDrawComponent>.NativeClassPtr, 100668311);
      DebugDrawComponent.NativeMethodInfoPtr_DrawCube_Public_Void_Vector3_Vector3_Color_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DebugDrawComponent>.NativeClassPtr, 100668312);
      DebugDrawComponent.NativeMethodInfoPtr_DrawString_Public_Void_Vector3_String_Color_ViewSpace_Int32_Nullable_Unboxed_1_Vector2_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DebugDrawComponent>.NativeClassPtr, 100668313);
      DebugDrawComponent.NativeMethodInfoPtr_DrawStringOneShot_Public_Void_Vector3_Vector3_String_Color_Single_ViewSpace_Int32_Nullable_Unboxed_1_Vector2_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DebugDrawComponent>.NativeClassPtr, 100668314);
      DebugDrawComponent.NativeMethodInfoPtr_OnDisable_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DebugDrawComponent>.NativeClassPtr, 100668315);
      DebugDrawComponent.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DebugDrawComponent>.NativeClassPtr, 100668316);
    }

    public DebugDrawComponent(System.IntPtr pointer)
      : base(pointer)
    {
    }

    public unsafe HashSet<string> _ActiveTags
    {
      get
      {
        System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(DebugDrawComponent.NativeFieldInfoPtr__ActiveTags));
        return pointer == System.IntPtr.Zero ? (HashSet<string>) null : new HashSet<string>(pointer);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(DebugDrawComponent.NativeFieldInfoPtr__ActiveTags), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe HashSet<string> _ExistingTags
    {
      get
      {
        System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(DebugDrawComponent.NativeFieldInfoPtr__ExistingTags));
        return pointer == System.IntPtr.Zero ? (HashSet<string>) null : new HashSet<string>(pointer);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(DebugDrawComponent.NativeFieldInfoPtr__ExistingTags), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe Dictionary<string, DebugWidget> _Widgets
    {
      get
      {
        System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(DebugDrawComponent.NativeFieldInfoPtr__Widgets));
        return pointer == System.IntPtr.Zero ? (Dictionary<string, DebugWidget>) null : new Dictionary<string, DebugWidget>(pointer);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(DebugDrawComponent.NativeFieldInfoPtr__Widgets), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe List<string> _RemoveList
    {
      get
      {
        System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(DebugDrawComponent.NativeFieldInfoPtr__RemoveList));
        return pointer == System.IntPtr.Zero ? (List<string>) null : new List<string>(pointer);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(DebugDrawComponent.NativeFieldInfoPtr__RemoveList), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe ModelDrawer _ModelDrawer
    {
      get
      {
        System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(DebugDrawComponent.NativeFieldInfoPtr__ModelDrawer));
        return pointer == System.IntPtr.Zero ? (ModelDrawer) null : new ModelDrawer(pointer);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(DebugDrawComponent.NativeFieldInfoPtr__ModelDrawer), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe HudDrawer _HudDrawer
    {
      get
      {
        System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(DebugDrawComponent.NativeFieldInfoPtr__HudDrawer));
        return pointer == System.IntPtr.Zero ? (HudDrawer) null : new HudDrawer(pointer);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(DebugDrawComponent.NativeFieldInfoPtr__HudDrawer), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe bool ShowAllTags
    {
      get
      {
        return *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(DebugDrawComponent.NativeFieldInfoPtr_ShowAllTags));
      }
      [param: In] set
      {
        *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(DebugDrawComponent.NativeFieldInfoPtr_ShowAllTags)) = value;
      }
    }

    public unsafe bool Active
    {
      get
      {
        return *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(DebugDrawComponent.NativeFieldInfoPtr_Active));
      }
      [param: In] set
      {
        *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(DebugDrawComponent.NativeFieldInfoPtr_Active)) = value;
      }
    }

    public unsafe float TimeoutDuration
    {
      get
      {
        return *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(DebugDrawComponent.NativeFieldInfoPtr_TimeoutDuration));
      }
      [param: In] set
      {
        *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(DebugDrawComponent.NativeFieldInfoPtr_TimeoutDuration)) = value;
      }
    }
  }
}
