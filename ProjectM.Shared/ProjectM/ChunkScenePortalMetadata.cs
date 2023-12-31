// Decompiled with JetBrains decompiler
// Type: ProjectM.ChunkScenePortalMetadata
// Assembly: ProjectM.Shared, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: CF03A298-FF93-4294-AFD6-565AD334A53C
// Assembly location: C:\Users\mitch\.nuget\packages\vrising.unhollowed.client\0.6.5.57575090\lib\net6.0\ProjectM.Shared.dll

using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using System.Runtime.InteropServices;
using Unity.Mathematics;

#nullable disable
namespace ProjectM
{
  [StructLayout(LayoutKind.Explicit)]
  public struct ChunkScenePortalMetadata
  {
    private static readonly System.IntPtr NativeFieldInfoPtr_MaxPortals;
    private static readonly System.IntPtr NativeFieldInfoPtr_Portal0;
    private static readonly System.IntPtr NativeFieldInfoPtr_Portal1;
    private static readonly System.IntPtr NativeFieldInfoPtr_Portal2;
    private static readonly System.IntPtr NativeFieldInfoPtr_Portal3;
    private static readonly System.IntPtr NativeMethodInfoPtr_get_Item_Public_get_Portal_Int32_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_set_Item_Public_set_Void_Int32_Portal_0;
    [FieldOffset(0)]
    public ChunkScenePortalMetadata.Portal Portal0;
    [FieldOffset(80)]
    public ChunkScenePortalMetadata.Portal Portal1;
    [FieldOffset(160)]
    public ChunkScenePortalMetadata.Portal Portal2;
    [FieldOffset(240)]
    public ChunkScenePortalMetadata.Portal Portal3;

    public unsafe ChunkScenePortalMetadata.Portal this[int index]
    {
      [CallerCount(3), CachedScanResults(RefRangeStart = 727510, RefRangeEnd = 727513, XrefRangeStart = 727510, XrefRangeEnd = 727510, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] get
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[1];
        numPtr[0] = (System.IntPtr) &index;
        System.IntPtr exc;
        System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(ChunkScenePortalMetadata.NativeMethodInfoPtr_get_Item_Public_get_Portal_Int32_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
        return *(ChunkScenePortalMetadata.Portal*) IL2CPP.il2cpp_object_unbox(num);
      }
      [CallerCount(1), CachedScanResults(RefRangeStart = 727513, RefRangeEnd = 727514, XrefRangeStart = 727513, XrefRangeEnd = 727513, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] set
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[2];
        numPtr[0] = (System.IntPtr) &index;
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &value;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(ChunkScenePortalMetadata.NativeMethodInfoPtr_set_Item_Public_set_Void_Int32_Portal_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }
    }

    static ChunkScenePortalMetadata()
    {
      Il2CppClassPointerStore<ChunkScenePortalMetadata>.NativeClassPtr = IL2CPP.GetIl2CppClass("ProjectM.Shared.dll", "ProjectM", nameof (ChunkScenePortalMetadata));
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ChunkScenePortalMetadata>.NativeClassPtr);
      ChunkScenePortalMetadata.NativeFieldInfoPtr_MaxPortals = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ChunkScenePortalMetadata>.NativeClassPtr, nameof (MaxPortals));
      ChunkScenePortalMetadata.NativeFieldInfoPtr_Portal0 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ChunkScenePortalMetadata>.NativeClassPtr, nameof (Portal0));
      ChunkScenePortalMetadata.NativeFieldInfoPtr_Portal1 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ChunkScenePortalMetadata>.NativeClassPtr, nameof (Portal1));
      ChunkScenePortalMetadata.NativeFieldInfoPtr_Portal2 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ChunkScenePortalMetadata>.NativeClassPtr, nameof (Portal2));
      ChunkScenePortalMetadata.NativeFieldInfoPtr_Portal3 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ChunkScenePortalMetadata>.NativeClassPtr, nameof (Portal3));
      ChunkScenePortalMetadata.NativeMethodInfoPtr_get_Item_Public_get_Portal_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ChunkScenePortalMetadata>.NativeClassPtr, 100664401);
      ChunkScenePortalMetadata.NativeMethodInfoPtr_set_Item_Public_set_Void_Int32_Portal_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ChunkScenePortalMetadata>.NativeClassPtr, 100664402);
    }

    public Il2CppSystem.Object BoxIl2CppObject()
    {
      return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<ChunkScenePortalMetadata>.NativeClassPtr, (System.IntPtr) ref this));
    }

    public static unsafe int MaxPortals
    {
      get
      {
        int maxPortals;
        IL2CPP.il2cpp_field_static_get_value(ChunkScenePortalMetadata.NativeFieldInfoPtr_MaxPortals, (void*) &maxPortals);
        return maxPortals;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(ChunkScenePortalMetadata.NativeFieldInfoPtr_MaxPortals, (void*) &value);
      }
    }

    [StructLayout(LayoutKind.Explicit)]
    public struct Portal
    {
      private static readonly System.IntPtr NativeFieldInfoPtr_PortalGUID;
      private static readonly System.IntPtr NativeFieldInfoPtr_LocalChunkTRS;
      private static readonly System.IntPtr NativeFieldInfoPtr_TransformIndex;
      [FieldOffset(0)]
      public PrefabGUID PortalGUID;
      [FieldOffset(4)]
      public float4x4 LocalChunkTRS;
      [FieldOffset(68)]
      public StaticTransformIndex TransformIndex;

      static Portal()
      {
        Il2CppClassPointerStore<ChunkScenePortalMetadata.Portal>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<ChunkScenePortalMetadata>.NativeClassPtr, nameof (Portal));
        IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ChunkScenePortalMetadata.Portal>.NativeClassPtr);
        ChunkScenePortalMetadata.Portal.NativeFieldInfoPtr_PortalGUID = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ChunkScenePortalMetadata.Portal>.NativeClassPtr, nameof (PortalGUID));
        ChunkScenePortalMetadata.Portal.NativeFieldInfoPtr_LocalChunkTRS = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ChunkScenePortalMetadata.Portal>.NativeClassPtr, nameof (LocalChunkTRS));
        ChunkScenePortalMetadata.Portal.NativeFieldInfoPtr_TransformIndex = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ChunkScenePortalMetadata.Portal>.NativeClassPtr, nameof (TransformIndex));
      }

      public Il2CppSystem.Object BoxIl2CppObject()
      {
        return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<ChunkScenePortalMetadata.Portal>.NativeClassPtr, (System.IntPtr) ref this));
      }
    }
  }
}
