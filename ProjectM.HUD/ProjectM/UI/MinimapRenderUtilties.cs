// Decompiled with JetBrains decompiler
// Type: ProjectM.UI.MinimapRenderUtilties
// Assembly: ProjectM.HUD, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 19DF27AB-2445-4ADB-A558-10C99A6E640A
// Assembly location: C:\Users\mitch\.nuget\packages\vrising.unhollowed.client\0.6.5.57575090\lib\net6.0\ProjectM.HUD.dll

using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using UnityEngine;
using UnityEngine.SceneManagement;

#nullable disable
namespace ProjectM.UI
{
  public static class MinimapRenderUtilties : Il2CppSystem.Object
  {
    private static readonly System.IntPtr NativeMethodInfoPtr_RenderMinimapFromLevelGeometry_Public_Static_Void_Int32_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_RenderMinimapTexture_Public_Static_Texture2D_Int32_byref_Matrix4x4_Scene_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_GetCurrentSceneMinimapTextureData_Internal_Static_TextureData_0;

    [CallerCount(10560)]
    [CachedScanResults(RefRangeStart = 24, RefRangeEnd = 10584, XrefRangeStart = 24, XrefRangeEnd = 10584, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public static unsafe void RenderMinimapFromLevelGeometry(int tileSize = 2048)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[1];
      numPtr[0] = (System.IntPtr) &tileSize;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(MinimapRenderUtilties.NativeMethodInfoPtr_RenderMinimapFromLevelGeometry_Public_Static_Void_Int32_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1273976, XrefRangeEnd = 1273993, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public static unsafe Texture2D RenderMinimapTexture(
      int tileSize,
      out Matrix4x4 viewProjectionMatrixResult,
      Scene activeScene)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[3];
      numPtr[0] = (System.IntPtr) &tileSize;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) ref viewProjectionMatrixResult;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = (System.IntPtr) &activeScene;
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(MinimapRenderUtilties.NativeMethodInfoPtr_RenderMinimapTexture_Public_Static_Texture2D_Int32_byref_Matrix4x4_Scene_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      System.IntPtr pointer = num;
      return pointer == System.IntPtr.Zero ? (Texture2D) null : new Texture2D(pointer);
    }

    [CallerCount(1474)]
    [CachedScanResults(RefRangeStart = 31223, RefRangeEnd = 32697, XrefRangeStart = 31223, XrefRangeEnd = 32697, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public static unsafe MiniMapTextureData.TextureData GetCurrentSceneMinimapTextureData()
    {
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(MinimapRenderUtilties.NativeMethodInfoPtr_GetCurrentSceneMinimapTextureData_Internal_Static_TextureData_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      System.IntPtr pointer = num;
      return pointer == System.IntPtr.Zero ? (MiniMapTextureData.TextureData) null : new MiniMapTextureData.TextureData(pointer);
    }

    static MinimapRenderUtilties()
    {
      Il2CppClassPointerStore<MinimapRenderUtilties>.NativeClassPtr = IL2CPP.GetIl2CppClass("ProjectM.HUD.dll", "ProjectM.UI", nameof (MinimapRenderUtilties));
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<MinimapRenderUtilties>.NativeClassPtr);
      MinimapRenderUtilties.NativeMethodInfoPtr_RenderMinimapFromLevelGeometry_Public_Static_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MinimapRenderUtilties>.NativeClassPtr, 100668303);
      MinimapRenderUtilties.NativeMethodInfoPtr_RenderMinimapTexture_Public_Static_Texture2D_Int32_byref_Matrix4x4_Scene_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MinimapRenderUtilties>.NativeClassPtr, 100668304);
      MinimapRenderUtilties.NativeMethodInfoPtr_GetCurrentSceneMinimapTextureData_Internal_Static_TextureData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MinimapRenderUtilties>.NativeClassPtr, 100668305);
    }

    public MinimapRenderUtilties(System.IntPtr pointer)
      : base(pointer)
    {
    }
  }
}
