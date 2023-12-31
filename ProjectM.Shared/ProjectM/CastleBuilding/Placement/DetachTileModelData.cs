// Decompiled with JetBrains decompiler
// Type: ProjectM.CastleBuilding.Placement.DetachTileModelData
// Assembly: ProjectM.Shared, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: CF03A298-FF93-4294-AFD6-565AD334A53C
// Assembly location: C:\Users\mitch\.nuget\packages\vrising.unhollowed.client\0.6.5.57575090\lib\net6.0\ProjectM.Shared.dll

using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using System.Runtime.InteropServices;
using Unity.Entities;

#nullable disable
namespace ProjectM.CastleBuilding.Placement
{
  [StructLayout(LayoutKind.Explicit)]
  public struct DetachTileModelData
  {
    private static readonly System.IntPtr NativeFieldInfoPtr_ChildEntity;
    private static readonly System.IntPtr NativeFieldInfoPtr_ParentEntity;
    private static readonly System.IntPtr NativeMethodInfoPtr_ToString_Public_Virtual_String_0;
    [FieldOffset(0)]
    public Entity ChildEntity;
    [FieldOffset(8)]
    public Entity ParentEntity;

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 794513, XrefRangeEnd = 794521, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public override unsafe string ToString()
    {
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      System.IntPtr il2CppString = IL2CPP.il2cpp_runtime_invoke(DetachTileModelData.NativeMethodInfoPtr_ToString_Public_Virtual_String_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return IL2CPP.Il2CppStringToManaged(il2CppString);
    }

    static DetachTileModelData()
    {
      Il2CppClassPointerStore<DetachTileModelData>.NativeClassPtr = IL2CPP.GetIl2CppClass("ProjectM.Shared.dll", "ProjectM.CastleBuilding.Placement", nameof (DetachTileModelData));
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<DetachTileModelData>.NativeClassPtr);
      DetachTileModelData.NativeFieldInfoPtr_ChildEntity = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DetachTileModelData>.NativeClassPtr, nameof (ChildEntity));
      DetachTileModelData.NativeFieldInfoPtr_ParentEntity = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DetachTileModelData>.NativeClassPtr, nameof (ParentEntity));
      DetachTileModelData.NativeMethodInfoPtr_ToString_Public_Virtual_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DetachTileModelData>.NativeClassPtr, 100670055);
    }

    public Il2CppSystem.Object BoxIl2CppObject()
    {
      return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<DetachTileModelData>.NativeClassPtr, (System.IntPtr) ref this));
    }
  }
}
