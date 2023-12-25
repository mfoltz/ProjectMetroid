// Decompiled with JetBrains decompiler
// Type: ProjectM.CastleBuilding.Placement.ServerGameManagerGetPlacementResult
// Assembly: ProjectM, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 83E42B70-D81B-4F1F-9FB5-6B5ABD5FF9FC
// Assembly location: C:\Users\mitch\.nuget\packages\vrising.unhollowed.client\0.6.5.57575090\lib\net6.0\ProjectM.dll

using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using ProjectM.Scripting;
using Unity.Entities;

#nullable disable
namespace ProjectM.CastleBuilding.Placement
{
  public static class ServerGameManagerGetPlacementResult : Il2CppSystem.Object
  {
    private static readonly System.IntPtr NativeMethodInfoPtr_GetPlacementResultsAsync_Public_Static_Void_byref_ServerGameManager_Entity_Operation_OnPlacementResultDelegate_0;

    [CallerCount(1)]
    [CachedScanResults(RefRangeStart = 1136945, RefRangeEnd = 1136946, XrefRangeStart = 1136936, XrefRangeEnd = 1136945, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public static unsafe void GetPlacementResultsAsync(
      ref this ServerGameManager game,
      Entity self,
      GetPlacementResult.Operation placementOperation,
      ServerScriptMapper.OnPlacementResultDelegate callback)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[4];
      numPtr[0] = (System.IntPtr) ref game;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &self;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = (System.IntPtr) &placementOperation;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(3) * sizeof (System.IntPtr))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) callback);
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(ServerGameManagerGetPlacementResult.NativeMethodInfoPtr_GetPlacementResultsAsync_Public_Static_Void_byref_ServerGameManager_Entity_Operation_OnPlacementResultDelegate_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    static ServerGameManagerGetPlacementResult()
    {
      Il2CppClassPointerStore<ServerGameManagerGetPlacementResult>.NativeClassPtr = IL2CPP.GetIl2CppClass("ProjectM.dll", "ProjectM.CastleBuilding.Placement", nameof (ServerGameManagerGetPlacementResult));
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ServerGameManagerGetPlacementResult>.NativeClassPtr);
      ServerGameManagerGetPlacementResult.NativeMethodInfoPtr_GetPlacementResultsAsync_Public_Static_Void_byref_ServerGameManager_Entity_Operation_OnPlacementResultDelegate_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ServerGameManagerGetPlacementResult>.NativeClassPtr, 100690018);
    }

    public ServerGameManagerGetPlacementResult(System.IntPtr pointer)
      : base(pointer)
    {
    }
  }
}
