// Decompiled with JetBrains decompiler
// Type: ProjectM.CastleBuilding.TerritoryTile
// Assembly: ProjectM.CastleBuilding.Systems, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DA7B9521-B45B-4FC8-A2B0-77040A5D8FB7
// Assembly location: C:\Users\mitch\.nuget\packages\vrising.unhollowed.client\0.6.5.57575090\lib\net6.0\ProjectM.CastleBuilding.Systems.dll

using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using System.Runtime.InteropServices;
using Unity.Entities;

#nullable disable
namespace ProjectM.CastleBuilding
{
  [StructLayout(LayoutKind.Explicit)]
  public struct TerritoryTile
  {
    private static readonly System.IntPtr NativeFieldInfoPtr_MeshEntity;
    private static readonly System.IntPtr NativeFieldInfoPtr_SideMeshEntity;
    private static readonly System.IntPtr NativeMethodInfoPtr_Equals_Public_Virtual_Final_New_Boolean_TerritoryTile_0;
    [FieldOffset(0)]
    public Entity MeshEntity;
    [FieldOffset(8)]
    public Entity SideMeshEntity;

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public virtual unsafe bool Equals(TerritoryTile other)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[1];
      numPtr[0] = (System.IntPtr) &other;
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(TerritoryTile.NativeMethodInfoPtr_Equals_Public_Virtual_Final_New_Boolean_TerritoryTile_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(bool*) IL2CPP.il2cpp_object_unbox(num);
    }

    static TerritoryTile()
    {
      Il2CppClassPointerStore<TerritoryTile>.NativeClassPtr = IL2CPP.GetIl2CppClass("ProjectM.CastleBuilding.Systems.dll", "ProjectM.CastleBuilding", nameof (TerritoryTile));
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<TerritoryTile>.NativeClassPtr);
      TerritoryTile.NativeFieldInfoPtr_MeshEntity = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TerritoryTile>.NativeClassPtr, nameof (MeshEntity));
      TerritoryTile.NativeFieldInfoPtr_SideMeshEntity = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TerritoryTile>.NativeClassPtr, nameof (SideMeshEntity));
      TerritoryTile.NativeMethodInfoPtr_Equals_Public_Virtual_Final_New_Boolean_TerritoryTile_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TerritoryTile>.NativeClassPtr, 100664382);
    }

    public Il2CppSystem.Object BoxIl2CppObject()
    {
      return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<TerritoryTile>.NativeClassPtr, (System.IntPtr) ref this));
    }
  }
}
