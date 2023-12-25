// Decompiled with JetBrains decompiler
// Type: ProjectM.AiMoveUtility
// Assembly: ProjectM, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 83E42B70-D81B-4F1F-9FB5-6B5ABD5FF9FC
// Assembly location: C:\Users\mitch\.nuget\packages\vrising.unhollowed.client\0.6.5.57575090\lib\net6.0\ProjectM.dll

using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using System.Runtime.InteropServices;
using Unity.Mathematics;

#nullable disable
namespace ProjectM
{
  public static class AiMoveUtility : Il2CppSystem.Object
  {
    private static readonly System.IntPtr NativeMethodInfoPtr_TryGetTargetPositionFromPath_Public_Static_Boolean_byref_AiMove_Shared_float2_Single_Single_byref_float2_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_FollowPath_Public_Static_Boolean_byref_AiMove_Shared_byref_EntityInput_float3_Single_Single_0;

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1053368, XrefRangeEnd = 1053370, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public static unsafe bool TryGetTargetPositionFromPath(
      [In] ref AiMove_Shared aiMoveShared,
      float2 position,
      float speed,
      float worldSpaceRadius,
      out float2 targetPosition)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[5];
      numPtr[0] = (System.IntPtr) ref aiMoveShared;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &position;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = (System.IntPtr) &speed;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(3) * sizeof (System.IntPtr))) = (System.IntPtr) &worldSpaceRadius;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(4) * sizeof (System.IntPtr))) = (System.IntPtr) ref targetPosition;
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(AiMoveUtility.NativeMethodInfoPtr_TryGetTargetPositionFromPath_Public_Static_Boolean_byref_AiMove_Shared_float2_Single_Single_byref_float2_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(bool*) IL2CPP.il2cpp_object_unbox(num);
    }

    [CallerCount(1)]
    [CachedScanResults(RefRangeStart = 1053377, RefRangeEnd = 1053378, XrefRangeStart = 1053370, XrefRangeEnd = 1053377, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public static unsafe bool FollowPath(
      [In] ref AiMove_Shared aiMoveShared,
      ref EntityInput entityInput,
      float3 position,
      float speed,
      float worldSpaceRadius)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[5];
      numPtr[0] = (System.IntPtr) ref aiMoveShared;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) ref entityInput;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = (System.IntPtr) &position;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(3) * sizeof (System.IntPtr))) = (System.IntPtr) &speed;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(4) * sizeof (System.IntPtr))) = (System.IntPtr) &worldSpaceRadius;
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(AiMoveUtility.NativeMethodInfoPtr_FollowPath_Public_Static_Boolean_byref_AiMove_Shared_byref_EntityInput_float3_Single_Single_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(bool*) IL2CPP.il2cpp_object_unbox(num);
    }

    static AiMoveUtility()
    {
      Il2CppClassPointerStore<AiMoveUtility>.NativeClassPtr = IL2CPP.GetIl2CppClass("ProjectM.dll", "ProjectM", nameof (AiMoveUtility));
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<AiMoveUtility>.NativeClassPtr);
      AiMoveUtility.NativeMethodInfoPtr_TryGetTargetPositionFromPath_Public_Static_Boolean_byref_AiMove_Shared_float2_Single_Single_byref_float2_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AiMoveUtility>.NativeClassPtr, 100682865);
      AiMoveUtility.NativeMethodInfoPtr_FollowPath_Public_Static_Boolean_byref_AiMove_Shared_byref_EntityInput_float3_Single_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AiMoveUtility>.NativeClassPtr, 100682866);
    }

    public AiMoveUtility(System.IntPtr pointer)
      : base(pointer)
    {
    }
  }
}
