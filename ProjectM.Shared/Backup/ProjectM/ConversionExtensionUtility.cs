// Decompiled with JetBrains decompiler
// Type: ProjectM.ConversionExtensionUtility
// Assembly: ProjectM.Shared, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: CF03A298-FF93-4294-AFD6-565AD334A53C
// Assembly location: C:\Users\mitch\.nuget\packages\vrising.unhollowed.client\0.6.5.57575090\lib\net6.0\ProjectM.Shared.dll

using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using UnityEngine;

#nullable disable
namespace ProjectM
{
  public static class ConversionExtensionUtility : Il2CppSystem.Object
  {
    private static readonly System.IntPtr NativeMethodInfoPtr_GetSafeAdditionalEntityCreationTarget_Public_Static_GameObject_GameObjectConversionSystem_0;

    [CallerCount(1)]
    [CachedScanResults(RefRangeStart = 764210, RefRangeEnd = 764211, XrefRangeStart = 764201, XrefRangeEnd = 764210, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public static unsafe GameObject GetSafeAdditionalEntityCreationTarget(
      this GameObjectConversionSystem conversionSystem)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[1];
      numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) conversionSystem);
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(ConversionExtensionUtility.NativeMethodInfoPtr_GetSafeAdditionalEntityCreationTarget_Public_Static_GameObject_GameObjectConversionSystem_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      System.IntPtr pointer = num;
      return pointer == System.IntPtr.Zero ? (GameObject) null : new GameObject(pointer);
    }

    static ConversionExtensionUtility()
    {
      Il2CppClassPointerStore<ConversionExtensionUtility>.NativeClassPtr = IL2CPP.GetIl2CppClass("ProjectM.Shared.dll", "ProjectM", nameof (ConversionExtensionUtility));
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ConversionExtensionUtility>.NativeClassPtr);
      ConversionExtensionUtility.NativeMethodInfoPtr_GetSafeAdditionalEntityCreationTarget_Public_Static_GameObject_GameObjectConversionSystem_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ConversionExtensionUtility>.NativeClassPtr, 100667514);
    }

    public ConversionExtensionUtility(System.IntPtr pointer)
      : base(pointer)
    {
    }
  }
}
