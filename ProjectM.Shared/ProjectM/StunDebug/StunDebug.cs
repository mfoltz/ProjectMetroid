// Decompiled with JetBrains decompiler
// Type: ProjectM.StunDebug.StunDebug
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
  public static class StunDebug : Il2CppSystem.Object
  {
    private static readonly System.IntPtr NativeFieldInfoPtr__DrawComponent;
    private static readonly System.IntPtr NativeFieldInfoPtr__Camera;
    private static readonly System.IntPtr NativeFieldInfoPtr__Tracker;
    private static readonly System.IntPtr NativeFieldInfoPtr__Active;
    private static readonly System.IntPtr NativeMethodInfoPtr_set_Active_Public_Static_set_Void_Boolean_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_get_Active_Public_Static_get_Boolean_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_set_ShowAllTags_Public_Static_set_Void_Boolean_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_get_ShowAllTags_Public_Static_get_Boolean_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_SetTagActive_Public_Static_Void_String_Boolean_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_IsTagActive_Public_Static_Boolean_String_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_GetTags_Public_Static_IEnumerable_1_String_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_GetActiveTags_Public_Static_IEnumerable_1_String_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_RegisterTag_Public_Static_Void_String_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_GetDebugDrawComponent_Private_Static_DebugDrawComponent_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_GetTracker_Private_Static_Tracker_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_GetRandomColor_Private_Static_Color_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_Update_Public_Static_Void_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_TrackValue_Public_Static_Void_String_Single_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_TrackPosition_Public_Static_Void_String_Vector3_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_TrackPosition_Public_Static_Void_String_Vector3_Single_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_DrawVectorOnScreen_Public_Static_Void_String_Vector2_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_DrawVectorOnScreen_Public_Static_Void_String_Vector2_Single_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_DrawString_Public_Static_Void_Vector3_String_Color_ViewSpace_Int32_Nullable_Unboxed_1_Vector2_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_DrawStringOneShot_Public_Static_Void_Vector3_String_Color_Single_ViewSpace_Int32_Nullable_Unboxed_1_Vector2_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_DrawStringOneShot_Public_Static_Void_Vector3_Vector3_String_Color_Single_ViewSpace_Int32_Nullable_Unboxed_1_Vector2_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_DrawSphere_Public_Static_Void_Vector3_Single_Color_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_DrawCube_Public_Static_Void_Vector3_Vector3_Color_0;

    public static unsafe bool Active
    {
      [CallerCount(0), CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 771506, XrefRangeEnd = 771518, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] set
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[1];
        numPtr[0] = (System.IntPtr) &value;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(ProjectM.StunDebug.StunDebug.NativeMethodInfoPtr_set_Active_Public_Static_set_Void_Boolean_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }
      [CallerCount(0), CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 771518, XrefRangeEnd = 771522, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] get
      {
        System.IntPtr* numPtr = (System.IntPtr*) null;
        System.IntPtr exc;
        System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(ProjectM.StunDebug.StunDebug.NativeMethodInfoPtr_get_Active_Public_Static_get_Boolean_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
        return *(bool*) IL2CPP.il2cpp_object_unbox(num);
      }
    }

    public static unsafe bool ShowAllTags
    {
      [CallerCount(0), CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 771522, XrefRangeEnd = 771530, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] set
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[1];
        numPtr[0] = (System.IntPtr) &value;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(ProjectM.StunDebug.StunDebug.NativeMethodInfoPtr_set_ShowAllTags_Public_Static_set_Void_Boolean_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }
      [CallerCount(0), CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 771530, XrefRangeEnd = 771538, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] get
      {
        System.IntPtr* numPtr = (System.IntPtr*) null;
        System.IntPtr exc;
        System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(ProjectM.StunDebug.StunDebug.NativeMethodInfoPtr_get_ShowAllTags_Public_Static_get_Boolean_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
        return *(bool*) IL2CPP.il2cpp_object_unbox(num);
      }
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 771538, XrefRangeEnd = 771547, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public static unsafe void SetTagActive(string tag, bool active)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[2];
      numPtr[0] = IL2CPP.ManagedStringToIl2Cpp(tag);
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &active;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(ProjectM.StunDebug.StunDebug.NativeMethodInfoPtr_SetTagActive_Public_Static_Void_String_Boolean_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 771547, XrefRangeEnd = 771555, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public static unsafe bool IsTagActive(string tag)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[1];
      numPtr[0] = IL2CPP.ManagedStringToIl2Cpp(tag);
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(ProjectM.StunDebug.StunDebug.NativeMethodInfoPtr_IsTagActive_Public_Static_Boolean_String_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(bool*) IL2CPP.il2cpp_object_unbox(num);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 771555, XrefRangeEnd = 771566, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public static unsafe IEnumerable<string> GetTags()
    {
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(ProjectM.StunDebug.StunDebug.NativeMethodInfoPtr_GetTags_Public_Static_IEnumerable_1_String_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      System.IntPtr pointer = num;
      return pointer == System.IntPtr.Zero ? (IEnumerable<string>) null : new IEnumerable<string>(pointer);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 771566, XrefRangeEnd = 771577, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public static unsafe IEnumerable<string> GetActiveTags()
    {
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(ProjectM.StunDebug.StunDebug.NativeMethodInfoPtr_GetActiveTags_Public_Static_IEnumerable_1_String_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      System.IntPtr pointer = num;
      return pointer == System.IntPtr.Zero ? (IEnumerable<string>) null : new IEnumerable<string>(pointer);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 771577, XrefRangeEnd = 771586, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public static unsafe void RegisterTag(string tag)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[1];
      numPtr[0] = IL2CPP.ManagedStringToIl2Cpp(tag);
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(ProjectM.StunDebug.StunDebug.NativeMethodInfoPtr_RegisterTag_Public_Static_Void_String_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(16)]
    [CachedScanResults(RefRangeStart = 771632, RefRangeEnd = 771648, XrefRangeStart = 771586, XrefRangeEnd = 771632, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public static unsafe DebugDrawComponent GetDebugDrawComponent()
    {
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(ProjectM.StunDebug.StunDebug.NativeMethodInfoPtr_GetDebugDrawComponent_Private_Static_DebugDrawComponent_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      System.IntPtr pointer = num;
      return pointer == System.IntPtr.Zero ? (DebugDrawComponent) null : new DebugDrawComponent(pointer);
    }

    [CallerCount(2)]
    [CachedScanResults(RefRangeStart = 771663, RefRangeEnd = 771665, XrefRangeStart = 771648, XrefRangeEnd = 771663, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public static unsafe Tracker GetTracker()
    {
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(ProjectM.StunDebug.StunDebug.NativeMethodInfoPtr_GetTracker_Private_Static_Tracker_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      System.IntPtr pointer = num;
      return pointer == System.IntPtr.Zero ? (Tracker) null : new Tracker(pointer);
    }

    [CallerCount(3)]
    [CachedScanResults(RefRangeStart = 771670, RefRangeEnd = 771673, XrefRangeStart = 771665, XrefRangeEnd = 771670, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public static unsafe Color GetRandomColor()
    {
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(ProjectM.StunDebug.StunDebug.NativeMethodInfoPtr_GetRandomColor_Private_Static_Color_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(Color*) IL2CPP.il2cpp_object_unbox(num);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 771673, XrefRangeEnd = 771691, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public static unsafe void Update()
    {
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(ProjectM.StunDebug.StunDebug.NativeMethodInfoPtr_Update_Public_Static_Void_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(1)]
    [CachedScanResults(RefRangeStart = 771722, RefRangeEnd = 771723, XrefRangeStart = 771691, XrefRangeEnd = 771722, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public static unsafe void TrackValue(string name, float value)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[2];
      numPtr[0] = IL2CPP.ManagedStringToIl2Cpp(name);
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &value;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(ProjectM.StunDebug.StunDebug.NativeMethodInfoPtr_TrackValue_Public_Static_Void_String_Single_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 771723, XrefRangeEnd = 771727, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public static unsafe void TrackPosition(string name, Vector3 position)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[2];
      numPtr[0] = IL2CPP.ManagedStringToIl2Cpp(name);
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &position;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(ProjectM.StunDebug.StunDebug.NativeMethodInfoPtr_TrackPosition_Public_Static_Void_String_Vector3_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(1)]
    [CachedScanResults(RefRangeStart = 771762, RefRangeEnd = 771763, XrefRangeStart = 771727, XrefRangeEnd = 771762, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public static unsafe void TrackPosition(string name, Vector3 position, float timeVisible)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[3];
      numPtr[0] = IL2CPP.ManagedStringToIl2Cpp(name);
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &position;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = (System.IntPtr) &timeVisible;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(ProjectM.StunDebug.StunDebug.NativeMethodInfoPtr_TrackPosition_Public_Static_Void_String_Vector3_Single_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 771763, XrefRangeEnd = 771767, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public static unsafe void DrawVectorOnScreen(string name, Vector2 vector)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[2];
      numPtr[0] = IL2CPP.ManagedStringToIl2Cpp(name);
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &vector;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(ProjectM.StunDebug.StunDebug.NativeMethodInfoPtr_DrawVectorOnScreen_Public_Static_Void_String_Vector2_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(1)]
    [CachedScanResults(RefRangeStart = 771788, RefRangeEnd = 771789, XrefRangeStart = 771767, XrefRangeEnd = 771788, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public static unsafe void DrawVectorOnScreen(string name, Vector2 vector, float size)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[3];
      numPtr[0] = IL2CPP.ManagedStringToIl2Cpp(name);
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &vector;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = (System.IntPtr) &size;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(ProjectM.StunDebug.StunDebug.NativeMethodInfoPtr_DrawVectorOnScreen_Public_Static_Void_String_Vector2_Single_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(8)]
    [CachedScanResults(RefRangeStart = 771800, RefRangeEnd = 771808, XrefRangeStart = 771789, XrefRangeEnd = 771800, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public static unsafe void DrawString(
      Vector3 position,
      string text,
      Color color,
      HudDrawer.ViewSpace viewSpace = HudDrawer.ViewSpace.WorldSpace,
      int fontSize = 20,
      Nullable_Unboxed<Vector2> pivot = default (Nullable_Unboxed<Vector2>))
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[6];
      numPtr[0] = (System.IntPtr) &position;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = IL2CPP.ManagedStringToIl2Cpp(text);
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = (System.IntPtr) &color;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(3) * sizeof (System.IntPtr))) = (System.IntPtr) &viewSpace;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(4) * sizeof (System.IntPtr))) = (System.IntPtr) &fontSize;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(5) * sizeof (System.IntPtr))) = (System.IntPtr) &pivot;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(ProjectM.StunDebug.StunDebug.NativeMethodInfoPtr_DrawString_Public_Static_Void_Vector3_String_Color_ViewSpace_Int32_Nullable_Unboxed_1_Vector2_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 771808, XrefRangeEnd = 771824, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public static unsafe void DrawStringOneShot(
      Vector3 position,
      string text,
      Color color,
      float lifetime = 1f,
      HudDrawer.ViewSpace viewSpace = HudDrawer.ViewSpace.WorldSpace,
      int fontSize = 20,
      Nullable_Unboxed<Vector2> pivot = default (Nullable_Unboxed<Vector2>))
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[7];
      numPtr[0] = (System.IntPtr) &position;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = IL2CPP.ManagedStringToIl2Cpp(text);
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = (System.IntPtr) &color;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(3) * sizeof (System.IntPtr))) = (System.IntPtr) &lifetime;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(4) * sizeof (System.IntPtr))) = (System.IntPtr) &viewSpace;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(5) * sizeof (System.IntPtr))) = (System.IntPtr) &fontSize;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(6) * sizeof (System.IntPtr))) = (System.IntPtr) &pivot;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(ProjectM.StunDebug.StunDebug.NativeMethodInfoPtr_DrawStringOneShot_Public_Static_Void_Vector3_String_Color_Single_ViewSpace_Int32_Nullable_Unboxed_1_Vector2_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(1)]
    [CachedScanResults(RefRangeStart = 771835, RefRangeEnd = 771836, XrefRangeStart = 771824, XrefRangeEnd = 771835, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public static unsafe void DrawStringOneShot(
      Vector3 position,
      Vector3 velocity,
      string text,
      Color color,
      float lifetime = 1f,
      HudDrawer.ViewSpace viewSpace = HudDrawer.ViewSpace.WorldSpace,
      int fontSize = 20,
      Nullable_Unboxed<Vector2> pivot = default (Nullable_Unboxed<Vector2>))
    {
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
      IL2CPP.il2cpp_runtime_invoke(ProjectM.StunDebug.StunDebug.NativeMethodInfoPtr_DrawStringOneShot_Public_Static_Void_Vector3_Vector3_String_Color_Single_ViewSpace_Int32_Nullable_Unboxed_1_Vector2_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 771836, XrefRangeEnd = 771847, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public static unsafe void DrawSphere(Vector3 position, float radius, Color color)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[3];
      numPtr[0] = (System.IntPtr) &position;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &radius;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = (System.IntPtr) &color;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(ProjectM.StunDebug.StunDebug.NativeMethodInfoPtr_DrawSphere_Public_Static_Void_Vector3_Single_Color_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 771847, XrefRangeEnd = 771858, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public static unsafe void DrawCube(Vector3 center, Vector3 scale, Color color)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[3];
      numPtr[0] = (System.IntPtr) &center;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &scale;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = (System.IntPtr) &color;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(ProjectM.StunDebug.StunDebug.NativeMethodInfoPtr_DrawCube_Public_Static_Void_Vector3_Vector3_Color_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    static StunDebug()
    {
      Il2CppClassPointerStore<ProjectM.StunDebug.StunDebug>.NativeClassPtr = IL2CPP.GetIl2CppClass("ProjectM.Shared.dll", "ProjectM.StunDebug", nameof (StunDebug));
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ProjectM.StunDebug.StunDebug>.NativeClassPtr);
      ProjectM.StunDebug.StunDebug.NativeFieldInfoPtr__DrawComponent = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ProjectM.StunDebug.StunDebug>.NativeClassPtr, nameof (_DrawComponent));
      ProjectM.StunDebug.StunDebug.NativeFieldInfoPtr__Camera = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ProjectM.StunDebug.StunDebug>.NativeClassPtr, nameof (_Camera));
      ProjectM.StunDebug.StunDebug.NativeFieldInfoPtr__Tracker = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ProjectM.StunDebug.StunDebug>.NativeClassPtr, nameof (_Tracker));
      ProjectM.StunDebug.StunDebug.NativeFieldInfoPtr__Active = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ProjectM.StunDebug.StunDebug>.NativeClassPtr, nameof (_Active));
      ProjectM.StunDebug.StunDebug.NativeMethodInfoPtr_set_Active_Public_Static_set_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ProjectM.StunDebug.StunDebug>.NativeClassPtr, 100668331);
      ProjectM.StunDebug.StunDebug.NativeMethodInfoPtr_get_Active_Public_Static_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ProjectM.StunDebug.StunDebug>.NativeClassPtr, 100668332);
      ProjectM.StunDebug.StunDebug.NativeMethodInfoPtr_set_ShowAllTags_Public_Static_set_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ProjectM.StunDebug.StunDebug>.NativeClassPtr, 100668333);
      ProjectM.StunDebug.StunDebug.NativeMethodInfoPtr_get_ShowAllTags_Public_Static_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ProjectM.StunDebug.StunDebug>.NativeClassPtr, 100668334);
      ProjectM.StunDebug.StunDebug.NativeMethodInfoPtr_SetTagActive_Public_Static_Void_String_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ProjectM.StunDebug.StunDebug>.NativeClassPtr, 100668335);
      ProjectM.StunDebug.StunDebug.NativeMethodInfoPtr_IsTagActive_Public_Static_Boolean_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ProjectM.StunDebug.StunDebug>.NativeClassPtr, 100668336);
      ProjectM.StunDebug.StunDebug.NativeMethodInfoPtr_GetTags_Public_Static_IEnumerable_1_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ProjectM.StunDebug.StunDebug>.NativeClassPtr, 100668337);
      ProjectM.StunDebug.StunDebug.NativeMethodInfoPtr_GetActiveTags_Public_Static_IEnumerable_1_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ProjectM.StunDebug.StunDebug>.NativeClassPtr, 100668338);
      ProjectM.StunDebug.StunDebug.NativeMethodInfoPtr_RegisterTag_Public_Static_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ProjectM.StunDebug.StunDebug>.NativeClassPtr, 100668339);
      ProjectM.StunDebug.StunDebug.NativeMethodInfoPtr_GetDebugDrawComponent_Private_Static_DebugDrawComponent_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ProjectM.StunDebug.StunDebug>.NativeClassPtr, 100668340);
      ProjectM.StunDebug.StunDebug.NativeMethodInfoPtr_GetTracker_Private_Static_Tracker_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ProjectM.StunDebug.StunDebug>.NativeClassPtr, 100668341);
      ProjectM.StunDebug.StunDebug.NativeMethodInfoPtr_GetRandomColor_Private_Static_Color_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ProjectM.StunDebug.StunDebug>.NativeClassPtr, 100668342);
      ProjectM.StunDebug.StunDebug.NativeMethodInfoPtr_Update_Public_Static_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ProjectM.StunDebug.StunDebug>.NativeClassPtr, 100668343);
      ProjectM.StunDebug.StunDebug.NativeMethodInfoPtr_TrackValue_Public_Static_Void_String_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ProjectM.StunDebug.StunDebug>.NativeClassPtr, 100668344);
      ProjectM.StunDebug.StunDebug.NativeMethodInfoPtr_TrackPosition_Public_Static_Void_String_Vector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ProjectM.StunDebug.StunDebug>.NativeClassPtr, 100668345);
      ProjectM.StunDebug.StunDebug.NativeMethodInfoPtr_TrackPosition_Public_Static_Void_String_Vector3_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ProjectM.StunDebug.StunDebug>.NativeClassPtr, 100668346);
      ProjectM.StunDebug.StunDebug.NativeMethodInfoPtr_DrawVectorOnScreen_Public_Static_Void_String_Vector2_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ProjectM.StunDebug.StunDebug>.NativeClassPtr, 100668347);
      ProjectM.StunDebug.StunDebug.NativeMethodInfoPtr_DrawVectorOnScreen_Public_Static_Void_String_Vector2_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ProjectM.StunDebug.StunDebug>.NativeClassPtr, 100668348);
      ProjectM.StunDebug.StunDebug.NativeMethodInfoPtr_DrawString_Public_Static_Void_Vector3_String_Color_ViewSpace_Int32_Nullable_Unboxed_1_Vector2_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ProjectM.StunDebug.StunDebug>.NativeClassPtr, 100668349);
      ProjectM.StunDebug.StunDebug.NativeMethodInfoPtr_DrawStringOneShot_Public_Static_Void_Vector3_String_Color_Single_ViewSpace_Int32_Nullable_Unboxed_1_Vector2_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ProjectM.StunDebug.StunDebug>.NativeClassPtr, 100668350);
      ProjectM.StunDebug.StunDebug.NativeMethodInfoPtr_DrawStringOneShot_Public_Static_Void_Vector3_Vector3_String_Color_Single_ViewSpace_Int32_Nullable_Unboxed_1_Vector2_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ProjectM.StunDebug.StunDebug>.NativeClassPtr, 100668351);
      ProjectM.StunDebug.StunDebug.NativeMethodInfoPtr_DrawSphere_Public_Static_Void_Vector3_Single_Color_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ProjectM.StunDebug.StunDebug>.NativeClassPtr, 100668352);
      ProjectM.StunDebug.StunDebug.NativeMethodInfoPtr_DrawCube_Public_Static_Void_Vector3_Vector3_Color_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ProjectM.StunDebug.StunDebug>.NativeClassPtr, 100668353);
    }

    public StunDebug(System.IntPtr pointer)
      : base(pointer)
    {
    }

    public static unsafe DebugDrawComponent _DrawComponent
    {
      get
      {
        System.IntPtr num;
        IL2CPP.il2cpp_field_static_get_value(ProjectM.StunDebug.StunDebug.NativeFieldInfoPtr__DrawComponent, (void*) &num);
        System.IntPtr pointer = num;
        return pointer == System.IntPtr.Zero ? (DebugDrawComponent) null : new DebugDrawComponent(pointer);
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(ProjectM.StunDebug.StunDebug.NativeFieldInfoPtr__DrawComponent, (void*) IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public static unsafe Camera _Camera
    {
      get
      {
        System.IntPtr num;
        IL2CPP.il2cpp_field_static_get_value(ProjectM.StunDebug.StunDebug.NativeFieldInfoPtr__Camera, (void*) &num);
        System.IntPtr pointer = num;
        return pointer == System.IntPtr.Zero ? (Camera) null : new Camera(pointer);
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(ProjectM.StunDebug.StunDebug.NativeFieldInfoPtr__Camera, (void*) IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public static unsafe Tracker _Tracker
    {
      get
      {
        System.IntPtr num;
        IL2CPP.il2cpp_field_static_get_value(ProjectM.StunDebug.StunDebug.NativeFieldInfoPtr__Tracker, (void*) &num);
        System.IntPtr pointer = num;
        return pointer == System.IntPtr.Zero ? (Tracker) null : new Tracker(pointer);
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(ProjectM.StunDebug.StunDebug.NativeFieldInfoPtr__Tracker, (void*) IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public static unsafe bool _Active
    {
      get
      {
        bool active;
        IL2CPP.il2cpp_field_static_get_value(ProjectM.StunDebug.StunDebug.NativeFieldInfoPtr__Active, (void*) &active);
        return active;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(ProjectM.StunDebug.StunDebug.NativeFieldInfoPtr__Active, (void*) &value);
      }
    }
  }
}
