// Decompiled with JetBrains decompiler
// Type: ProjectM.SpawnChainUtility
// Assembly: ProjectM.Shared, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: CF03A298-FF93-4294-AFD6-565AD334A53C
// Assembly location: C:\Users\mitch\.nuget\packages\vrising.unhollowed.client\0.6.5.57575090\lib\net6.0\ProjectM.Shared.dll

using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using System.Runtime.InteropServices;

#nullable disable
namespace ProjectM
{
  public static class SpawnChainUtility : Il2CppSystem.Object
  {
    private static readonly System.IntPtr NativeMethodInfoPtr_GetRemainingDuration_Public_Static_Double_byref_AutoChainInstanceData_Double_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_GetTimePassed_Public_Static_Double_byref_AutoChainInstanceData_AutoChainTransitionConstants_Double_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_CreateAutoChainData_Public_Static_AutoChainInstanceData_Boolean_AutoChainTransitionConstants_Double_Double_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_TryCalculateDurationUntilMainElement_Public_Static_Boolean_Int32_SpawnChainConstants_byref_Double_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_GetRandomInitialSpawnChainElementElapsed_Public_Static_Double_byref_Random_byref_ChainElement_0;

    [CallerCount(0)]
    public static unsafe double GetRemainingDuration(
      [In] ref AutoChainInstanceData instanceData,
      double serverElapsedSeconds)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[2];
      numPtr[0] = (System.IntPtr) ref instanceData;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &serverElapsedSeconds;
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(SpawnChainUtility.NativeMethodInfoPtr_GetRemainingDuration_Public_Static_Double_byref_AutoChainInstanceData_Double_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(double*) IL2CPP.il2cpp_object_unbox(num);
    }

    [CallerCount(1)]
    [CachedScanResults(RefRangeStart = 728546, RefRangeEnd = 728547, XrefRangeStart = 728546, XrefRangeEnd = 728546, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public static unsafe double GetTimePassed(
      [In] ref AutoChainInstanceData instanceData,
      AutoChainTransitionConstants constants,
      double serverElapsedSeconds)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[3];
      numPtr[0] = (System.IntPtr) ref instanceData;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &constants;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = (System.IntPtr) &serverElapsedSeconds;
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(SpawnChainUtility.NativeMethodInfoPtr_GetTimePassed_Public_Static_Double_byref_AutoChainInstanceData_AutoChainTransitionConstants_Double_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(double*) IL2CPP.il2cpp_object_unbox(num);
    }

    [CallerCount(2)]
    [CachedScanResults(RefRangeStart = 728547, RefRangeEnd = 728549, XrefRangeStart = 728547, XrefRangeEnd = 728547, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public static unsafe AutoChainInstanceData CreateAutoChainData(
      bool usesAutoChain,
      AutoChainTransitionConstants autoChainConstants,
      double serverElapsedSeconds,
      double durationToPassForward)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[4];
      numPtr[0] = (System.IntPtr) &usesAutoChain;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &autoChainConstants;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = (System.IntPtr) &serverElapsedSeconds;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(3) * sizeof (System.IntPtr))) = (System.IntPtr) &durationToPassForward;
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(SpawnChainUtility.NativeMethodInfoPtr_CreateAutoChainData_Public_Static_AutoChainInstanceData_Boolean_AutoChainTransitionConstants_Double_Double_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(AutoChainInstanceData*) IL2CPP.il2cpp_object_unbox(num);
    }

    [CallerCount(1)]
    [CachedScanResults(RefRangeStart = 728563, RefRangeEnd = 728564, XrefRangeStart = 728549, XrefRangeEnd = 728563, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public static unsafe bool TryCalculateDurationUntilMainElement(
      int fromElementIndex,
      SpawnChainData.SpawnChainConstants chainConstants,
      out double autoTransitionDurationToMainElement)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[3];
      numPtr[0] = (System.IntPtr) &fromElementIndex;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &chainConstants;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = (System.IntPtr) ref autoTransitionDurationToMainElement;
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(SpawnChainUtility.NativeMethodInfoPtr_TryCalculateDurationUntilMainElement_Public_Static_Boolean_Int32_SpawnChainConstants_byref_Double_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(bool*) IL2CPP.il2cpp_object_unbox(num);
    }

    [CallerCount(2)]
    [CachedScanResults(RefRangeStart = 728564, RefRangeEnd = 728566, XrefRangeStart = 728564, XrefRangeEnd = 728564, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public static unsafe double GetRandomInitialSpawnChainElementElapsed(
      ref Unity.Mathematics.Random random,
      ref SpawnChainBlobAsset.ChainElement spawnChainElement)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[2];
      numPtr[0] = (System.IntPtr) ref random;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) ref spawnChainElement;
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(SpawnChainUtility.NativeMethodInfoPtr_GetRandomInitialSpawnChainElementElapsed_Public_Static_Double_byref_Random_byref_ChainElement_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(double*) IL2CPP.il2cpp_object_unbox(num);
    }

    static SpawnChainUtility()
    {
      Il2CppClassPointerStore<SpawnChainUtility>.NativeClassPtr = IL2CPP.GetIl2CppClass("ProjectM.Shared.dll", "ProjectM", nameof (SpawnChainUtility));
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<SpawnChainUtility>.NativeClassPtr);
      SpawnChainUtility.NativeMethodInfoPtr_GetRemainingDuration_Public_Static_Double_byref_AutoChainInstanceData_Double_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SpawnChainUtility>.NativeClassPtr, 100664513);
      SpawnChainUtility.NativeMethodInfoPtr_GetTimePassed_Public_Static_Double_byref_AutoChainInstanceData_AutoChainTransitionConstants_Double_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SpawnChainUtility>.NativeClassPtr, 100664514);
      SpawnChainUtility.NativeMethodInfoPtr_CreateAutoChainData_Public_Static_AutoChainInstanceData_Boolean_AutoChainTransitionConstants_Double_Double_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SpawnChainUtility>.NativeClassPtr, 100664515);
      SpawnChainUtility.NativeMethodInfoPtr_TryCalculateDurationUntilMainElement_Public_Static_Boolean_Int32_SpawnChainConstants_byref_Double_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SpawnChainUtility>.NativeClassPtr, 100664516);
      SpawnChainUtility.NativeMethodInfoPtr_GetRandomInitialSpawnChainElementElapsed_Public_Static_Double_byref_Random_byref_ChainElement_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SpawnChainUtility>.NativeClassPtr, 100664517);
    }

    public SpawnChainUtility(System.IntPtr pointer)
      : base(pointer)
    {
    }
  }
}
