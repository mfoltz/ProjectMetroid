// Decompiled with JetBrains decompiler
// Type: ProjectM.GameDataSubSceneAuthoring
// Assembly: ProjectM.Shared, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: CF03A298-FF93-4294-AFD6-565AD334A53C
// Assembly location: C:\Users\mitch\.nuget\packages\vrising.unhollowed.client\0.6.5.57575090\lib\net6.0\ProjectM.Shared.dll

using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppSystem.Collections.Generic;
using System;
using System.Runtime.InteropServices;
using UnityEngine;

#nullable disable
namespace ProjectM
{
  public class GameDataSubSceneAuthoring : MonoBehaviour
  {
    private static readonly IntPtr NativeFieldInfoPtr_GameData;
    private static readonly IntPtr NativeMethodInfoPtr_DeclareReferencedPrefabs_Public_Virtual_Final_New_Void_List_1_GameObject_0;
    private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 735068, XrefRangeEnd = 735073, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public virtual unsafe void DeclareReferencedPrefabs(List<GameObject> referencedPrefabs)
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IntPtr* numPtr = stackalloc IntPtr[1];
      numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) referencedPrefabs);
      IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(GameDataSubSceneAuthoring.NativeMethodInfoPtr_DeclareReferencedPrefabs_Public_Virtual_Final_New_Void_List_1_GameObject_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(520)]
    [CachedScanResults(RefRangeStart = 309669, RefRangeEnd = 310189, XrefRangeStart = 309669, XrefRangeEnd = 310189, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe GameDataSubSceneAuthoring()
      : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<GameDataSubSceneAuthoring>.NativeClassPtr))
    {
      IntPtr* numPtr = (IntPtr*) null;
      IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(GameDataSubSceneAuthoring.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    static GameDataSubSceneAuthoring()
    {
      Il2CppClassPointerStore<GameDataSubSceneAuthoring>.NativeClassPtr = IL2CPP.GetIl2CppClass("ProjectM.Shared.dll", "ProjectM", nameof (GameDataSubSceneAuthoring));
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<GameDataSubSceneAuthoring>.NativeClassPtr);
      GameDataSubSceneAuthoring.NativeFieldInfoPtr_GameData = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GameDataSubSceneAuthoring>.NativeClassPtr, nameof (GameData));
      GameDataSubSceneAuthoring.NativeMethodInfoPtr_DeclareReferencedPrefabs_Public_Virtual_Final_New_Void_List_1_GameObject_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GameDataSubSceneAuthoring>.NativeClassPtr, 100664910);
      GameDataSubSceneAuthoring.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GameDataSubSceneAuthoring>.NativeClassPtr, 100664911);
    }

    public GameDataSubSceneAuthoring(IntPtr pointer)
      : base(pointer)
    {
    }

    public unsafe PrefabCollectionAuthoring GameData
    {
      get
      {
        IntPtr pointer = *(IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(GameDataSubSceneAuthoring.NativeFieldInfoPtr_GameData));
        return pointer == IntPtr.Zero ? (PrefabCollectionAuthoring) null : new PrefabCollectionAuthoring(pointer);
      }
      [param: In] set
      {
        IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(GameDataSubSceneAuthoring.NativeFieldInfoPtr_GameData), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }
  }
}
