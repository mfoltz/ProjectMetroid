// Decompiled with JetBrains decompiler
// Type: ProjectM.CastleBuilding.CastleHeart
// Assembly: ProjectM.Shared, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: CF03A298-FF93-4294-AFD6-565AD334A53C
// Assembly location: C:\Users\mitch\.nuget\packages\vrising.unhollowed.client\0.6.5.57575090\lib\net6.0\ProjectM.Shared.dll

using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using ProjectM.Terrain;
using System.Runtime.InteropServices;
using Unity.Entities;

#nullable disable
namespace ProjectM.CastleBuilding
{
  [StructLayout(LayoutKind.Explicit)]
  public struct CastleHeart
  {
    private static readonly System.IntPtr NativeFieldInfoPtr_CastleRaidEndTime;
    private static readonly System.IntPtr NativeFieldInfoPtr_CastleSiegeEndTime;
    private static readonly System.IntPtr NativeFieldInfoPtr_MinorCastleSiegeEndTime;
    private static readonly System.IntPtr NativeFieldInfoPtr_LastAnnouncementTime;
    private static readonly System.IntPtr NativeFieldInfoPtr_CastleTerritoryId;
    private static readonly System.IntPtr NativeFieldInfoPtr_CastleTerritoryEntity;
    private static readonly System.IntPtr NativeMethodInfoPtr_CanBuild_Public_Boolean_Double_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_IsRaided_Public_Boolean_Double_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_IsSieged_Public_Boolean_Double_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_IsAttacked_Public_Boolean_Double_0;
    [FieldOffset(0)]
    public double CastleRaidEndTime;
    [FieldOffset(8)]
    public double CastleSiegeEndTime;
    [FieldOffset(16)]
    public double MinorCastleSiegeEndTime;
    [FieldOffset(24)]
    public double LastAnnouncementTime;
    [FieldOffset(32)]
    public MapZoneId CastleTerritoryId;
    [FieldOffset(44)]
    public Entity CastleTerritoryEntity;

    [CallerCount(5)]
    [CachedScanResults(RefRangeStart = 794009, RefRangeEnd = 794014, XrefRangeStart = 794009, XrefRangeEnd = 794009, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe bool CanBuild(double serverTime)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[1];
      numPtr[0] = (System.IntPtr) &serverTime;
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(CastleHeart.NativeMethodInfoPtr_CanBuild_Public_Boolean_Double_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(bool*) IL2CPP.il2cpp_object_unbox(num);
    }

    [CallerCount(3)]
    [CachedScanResults(RefRangeStart = 794014, RefRangeEnd = 794017, XrefRangeStart = 794014, XrefRangeEnd = 794014, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe bool IsRaided(double serverTime)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[1];
      numPtr[0] = (System.IntPtr) &serverTime;
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(CastleHeart.NativeMethodInfoPtr_IsRaided_Public_Boolean_Double_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(bool*) IL2CPP.il2cpp_object_unbox(num);
    }

    [CallerCount(3)]
    [CachedScanResults(RefRangeStart = 794017, RefRangeEnd = 794020, XrefRangeStart = 794017, XrefRangeEnd = 794017, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe bool IsSieged(double serverTime)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[1];
      numPtr[0] = (System.IntPtr) &serverTime;
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(CastleHeart.NativeMethodInfoPtr_IsSieged_Public_Boolean_Double_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(bool*) IL2CPP.il2cpp_object_unbox(num);
    }

    [CallerCount(3)]
    [CachedScanResults(RefRangeStart = 794020, RefRangeEnd = 794023, XrefRangeStart = 794020, XrefRangeEnd = 794020, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe bool IsAttacked(double serverTime)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[1];
      numPtr[0] = (System.IntPtr) &serverTime;
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(CastleHeart.NativeMethodInfoPtr_IsAttacked_Public_Boolean_Double_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(bool*) IL2CPP.il2cpp_object_unbox(num);
    }

    static CastleHeart()
    {
      Il2CppClassPointerStore<CastleHeart>.NativeClassPtr = IL2CPP.GetIl2CppClass("ProjectM.Shared.dll", "ProjectM.CastleBuilding", nameof (CastleHeart));
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<CastleHeart>.NativeClassPtr);
      CastleHeart.NativeFieldInfoPtr_CastleRaidEndTime = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CastleHeart>.NativeClassPtr, nameof (CastleRaidEndTime));
      CastleHeart.NativeFieldInfoPtr_CastleSiegeEndTime = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CastleHeart>.NativeClassPtr, nameof (CastleSiegeEndTime));
      CastleHeart.NativeFieldInfoPtr_MinorCastleSiegeEndTime = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CastleHeart>.NativeClassPtr, nameof (MinorCastleSiegeEndTime));
      CastleHeart.NativeFieldInfoPtr_LastAnnouncementTime = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CastleHeart>.NativeClassPtr, nameof (LastAnnouncementTime));
      CastleHeart.NativeFieldInfoPtr_CastleTerritoryId = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CastleHeart>.NativeClassPtr, nameof (CastleTerritoryId));
      CastleHeart.NativeFieldInfoPtr_CastleTerritoryEntity = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CastleHeart>.NativeClassPtr, nameof (CastleTerritoryEntity));
      CastleHeart.NativeMethodInfoPtr_CanBuild_Public_Boolean_Double_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CastleHeart>.NativeClassPtr, 100669989);
      CastleHeart.NativeMethodInfoPtr_IsRaided_Public_Boolean_Double_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CastleHeart>.NativeClassPtr, 100669990);
      CastleHeart.NativeMethodInfoPtr_IsSieged_Public_Boolean_Double_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CastleHeart>.NativeClassPtr, 100669991);
      CastleHeart.NativeMethodInfoPtr_IsAttacked_Public_Boolean_Double_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CastleHeart>.NativeClassPtr, 100669992);
    }

    public Il2CppSystem.Object BoxIl2CppObject()
    {
      return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<CastleHeart>.NativeClassPtr, (System.IntPtr) ref this));
    }
  }
}
