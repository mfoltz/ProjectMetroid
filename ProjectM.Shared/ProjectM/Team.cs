// Decompiled with JetBrains decompiler
// Type: ProjectM.Team
// Assembly: ProjectM.Shared, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: CF03A298-FF93-4294-AFD6-565AD334A53C
// Assembly location: C:\Users\mitch\.nuget\packages\vrising.unhollowed.client\0.6.5.57575090\lib\net6.0\ProjectM.Shared.dll

using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using System.Runtime.InteropServices;
using Unity.Entities;

#nullable disable
namespace ProjectM
{
  [StructLayout(LayoutKind.Explicit)]
  public struct Team
  {
    private static readonly System.IntPtr NativeFieldInfoPtr_UNIT_TEAM;
    private static readonly System.IntPtr NativeFieldInfoPtr_NEUTRAL_TEAM;
    private static readonly System.IntPtr NativeFieldInfoPtr_Value;
    private static readonly System.IntPtr NativeFieldInfoPtr_FactionIndex;
    private static readonly System.IntPtr NativeMethodInfoPtr_IsValid_Public_Boolean_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_IsAllies_Public_Static_Boolean_Team_Team_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_IsAllies_Public_Static_Boolean_EntityManager_Entity_Entity_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_IsAllies_Public_Static_Boolean_byref_ComponentDataFromEntity_1_Team_Entity_Entity_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_IsHostile_Public_Static_Boolean_Team_Team_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_IsInNeutralTeam_Public_Static_Boolean_Team_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_IsInUnitTeam_Public_Static_Boolean_Team_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_Equals_Public_Boolean_Team_0;
    [FieldOffset(0)]
    public int Value;
    [FieldOffset(4)]
    public int FactionIndex;

    [CallerCount(38)]
    [CachedScanResults(RefRangeStart = 723758, RefRangeEnd = 723796, XrefRangeStart = 723758, XrefRangeEnd = 723796, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe bool IsValid()
    {
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(Team.NativeMethodInfoPtr_IsValid_Public_Boolean_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(bool*) IL2CPP.il2cpp_object_unbox(num);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 730988, XrefRangeEnd = 730992, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public static unsafe bool IsAllies(Team team1, Team team2)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[2];
      numPtr[0] = (System.IntPtr) &team1;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &team2;
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(Team.NativeMethodInfoPtr_IsAllies_Public_Static_Boolean_Team_Team_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(bool*) IL2CPP.il2cpp_object_unbox(num);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 730992, XrefRangeEnd = 730998, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public static unsafe bool IsAllies(EntityManager entityManager, Entity entity1, Entity entity2)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[3];
      numPtr[0] = (System.IntPtr) &entityManager;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &entity1;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = (System.IntPtr) &entity2;
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(Team.NativeMethodInfoPtr_IsAllies_Public_Static_Boolean_EntityManager_Entity_Entity_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(bool*) IL2CPP.il2cpp_object_unbox(num);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 730998, XrefRangeEnd = 731009, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public static unsafe bool IsAllies(
      ref ComponentDataFromEntity<Team> getTeam,
      Entity entity1,
      Entity entity2)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[3];
      numPtr[0] = (System.IntPtr) ref getTeam;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &entity1;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = (System.IntPtr) &entity2;
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(Team.NativeMethodInfoPtr_IsAllies_Public_Static_Boolean_byref_ComponentDataFromEntity_1_Team_Entity_Entity_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(bool*) IL2CPP.il2cpp_object_unbox(num);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 731009, XrefRangeEnd = 731026, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public static unsafe bool IsHostile(Team team1, Team team2)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[2];
      numPtr[0] = (System.IntPtr) &team1;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &team2;
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(Team.NativeMethodInfoPtr_IsHostile_Public_Static_Boolean_Team_Team_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(bool*) IL2CPP.il2cpp_object_unbox(num);
    }

    [CallerCount(0)]
    public static unsafe bool IsInNeutralTeam(Team team)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[1];
      numPtr[0] = (System.IntPtr) &team;
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(Team.NativeMethodInfoPtr_IsInNeutralTeam_Public_Static_Boolean_Team_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(bool*) IL2CPP.il2cpp_object_unbox(num);
    }

    [CallerCount(13)]
    [CachedScanResults(RefRangeStart = 724100, RefRangeEnd = 724113, XrefRangeStart = 724100, XrefRangeEnd = 724113, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public static unsafe bool IsInUnitTeam(Team team)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[1];
      numPtr[0] = (System.IntPtr) &team;
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(Team.NativeMethodInfoPtr_IsInUnitTeam_Public_Static_Boolean_Team_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(bool*) IL2CPP.il2cpp_object_unbox(num);
    }

    [CallerCount(2)]
    [CachedScanResults(RefRangeStart = 261548, RefRangeEnd = 261550, XrefRangeStart = 261548, XrefRangeEnd = 261550, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe bool Equals(Team other)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[1];
      numPtr[0] = (System.IntPtr) &other;
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(Team.NativeMethodInfoPtr_Equals_Public_Boolean_Team_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(bool*) IL2CPP.il2cpp_object_unbox(num);
    }

    static Team()
    {
      Il2CppClassPointerStore<Team>.NativeClassPtr = IL2CPP.GetIl2CppClass("ProjectM.Shared.dll", "ProjectM", nameof (Team));
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Team>.NativeClassPtr);
      Team.NativeFieldInfoPtr_UNIT_TEAM = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Team>.NativeClassPtr, nameof (UNIT_TEAM));
      Team.NativeFieldInfoPtr_NEUTRAL_TEAM = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Team>.NativeClassPtr, nameof (NEUTRAL_TEAM));
      Team.NativeFieldInfoPtr_Value = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Team>.NativeClassPtr, nameof (Value));
      Team.NativeFieldInfoPtr_FactionIndex = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Team>.NativeClassPtr, nameof (FactionIndex));
      Team.NativeMethodInfoPtr_IsValid_Public_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Team>.NativeClassPtr, 100664616);
      Team.NativeMethodInfoPtr_IsAllies_Public_Static_Boolean_Team_Team_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Team>.NativeClassPtr, 100664617);
      Team.NativeMethodInfoPtr_IsAllies_Public_Static_Boolean_EntityManager_Entity_Entity_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Team>.NativeClassPtr, 100664618);
      Team.NativeMethodInfoPtr_IsAllies_Public_Static_Boolean_byref_ComponentDataFromEntity_1_Team_Entity_Entity_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Team>.NativeClassPtr, 100664619);
      Team.NativeMethodInfoPtr_IsHostile_Public_Static_Boolean_Team_Team_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Team>.NativeClassPtr, 100664620);
      Team.NativeMethodInfoPtr_IsInNeutralTeam_Public_Static_Boolean_Team_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Team>.NativeClassPtr, 100664621);
      Team.NativeMethodInfoPtr_IsInUnitTeam_Public_Static_Boolean_Team_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Team>.NativeClassPtr, 100664622);
      Team.NativeMethodInfoPtr_Equals_Public_Boolean_Team_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Team>.NativeClassPtr, 100664623);
    }

    public Il2CppSystem.Object BoxIl2CppObject()
    {
      return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<Team>.NativeClassPtr, (System.IntPtr) ref this));
    }

    public static unsafe int UNIT_TEAM
    {
      get
      {
        int unitTeam;
        IL2CPP.il2cpp_field_static_get_value(Team.NativeFieldInfoPtr_UNIT_TEAM, (void*) &unitTeam);
        return unitTeam;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(Team.NativeFieldInfoPtr_UNIT_TEAM, (void*) &value);
      }
    }

    public static unsafe int NEUTRAL_TEAM
    {
      get
      {
        int neutralTeam;
        IL2CPP.il2cpp_field_static_get_value(Team.NativeFieldInfoPtr_NEUTRAL_TEAM, (void*) &neutralTeam);
        return neutralTeam;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(Team.NativeFieldInfoPtr_NEUTRAL_TEAM, (void*) &value);
      }
    }
  }
}
