// Decompiled with JetBrains decompiler
// Type: ProjectM.RuntimeConversionBlobAssetStores
// Assembly: ProjectM.Shared, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: CF03A298-FF93-4294-AFD6-565AD334A53C
// Assembly location: C:\Users\mitch\.nuget\packages\vrising.unhollowed.client\0.6.5.57575090\lib\net6.0\ProjectM.Shared.dll

using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppSystem.Collections.Generic;
using System.Runtime.InteropServices;
using Unity.Entities;

#nullable disable
namespace ProjectM
{
  public static class RuntimeConversionBlobAssetStores : Il2CppSystem.Object
  {
    private static readonly System.IntPtr NativeFieldInfoPtr__Stores;
    private static readonly System.IntPtr NativeFieldInfoPtr__UserCount;
    private static readonly System.IntPtr NativeMethodInfoPtr_RegisterUser_Public_Static_Void_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_UnregisterUser_Public_Static_Void_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_GetStoreForNewRuntimeConversion_Public_Static_BlobAssetStore_0;

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 722065, XrefRangeEnd = 722069, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public static unsafe void RegisterUser()
    {
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(RuntimeConversionBlobAssetStores.NativeMethodInfoPtr_RegisterUser_Public_Static_Void_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 722069, XrefRangeEnd = 722097, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public static unsafe void UnregisterUser()
    {
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(RuntimeConversionBlobAssetStores.NativeMethodInfoPtr_UnregisterUser_Public_Static_Void_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 722097, XrefRangeEnd = 722108, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public static unsafe BlobAssetStore GetStoreForNewRuntimeConversion()
    {
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(RuntimeConversionBlobAssetStores.NativeMethodInfoPtr_GetStoreForNewRuntimeConversion_Public_Static_BlobAssetStore_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      System.IntPtr pointer = num;
      return pointer == System.IntPtr.Zero ? (BlobAssetStore) null : new BlobAssetStore(pointer);
    }

    static RuntimeConversionBlobAssetStores()
    {
      Il2CppClassPointerStore<RuntimeConversionBlobAssetStores>.NativeClassPtr = IL2CPP.GetIl2CppClass("ProjectM.Shared.dll", "ProjectM", nameof (RuntimeConversionBlobAssetStores));
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<RuntimeConversionBlobAssetStores>.NativeClassPtr);
      RuntimeConversionBlobAssetStores.NativeFieldInfoPtr__Stores = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RuntimeConversionBlobAssetStores>.NativeClassPtr, nameof (_Stores));
      RuntimeConversionBlobAssetStores.NativeFieldInfoPtr__UserCount = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RuntimeConversionBlobAssetStores>.NativeClassPtr, nameof (_UserCount));
      RuntimeConversionBlobAssetStores.NativeMethodInfoPtr_RegisterUser_Public_Static_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RuntimeConversionBlobAssetStores>.NativeClassPtr, 100663756);
      RuntimeConversionBlobAssetStores.NativeMethodInfoPtr_UnregisterUser_Public_Static_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RuntimeConversionBlobAssetStores>.NativeClassPtr, 100663757);
      RuntimeConversionBlobAssetStores.NativeMethodInfoPtr_GetStoreForNewRuntimeConversion_Public_Static_BlobAssetStore_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RuntimeConversionBlobAssetStores>.NativeClassPtr, 100663758);
    }

    public RuntimeConversionBlobAssetStores(System.IntPtr pointer)
      : base(pointer)
    {
    }

    public static unsafe List<BlobAssetStore> _Stores
    {
      get
      {
        System.IntPtr num;
        IL2CPP.il2cpp_field_static_get_value(RuntimeConversionBlobAssetStores.NativeFieldInfoPtr__Stores, (void*) &num);
        System.IntPtr pointer = num;
        return pointer == System.IntPtr.Zero ? (List<BlobAssetStore>) null : new List<BlobAssetStore>(pointer);
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(RuntimeConversionBlobAssetStores.NativeFieldInfoPtr__Stores, (void*) IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public static unsafe int _UserCount
    {
      get
      {
        int userCount;
        IL2CPP.il2cpp_field_static_get_value(RuntimeConversionBlobAssetStores.NativeFieldInfoPtr__UserCount, (void*) &userCount);
        return userCount;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(RuntimeConversionBlobAssetStores.NativeFieldInfoPtr__UserCount, (void*) &value);
      }
    }
  }
}
