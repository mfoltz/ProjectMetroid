// Decompiled with JetBrains decompiler
// Type: ProjectM.FactionRelationships
// Assembly: ProjectM.Shared, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: CF03A298-FF93-4294-AFD6-565AD334A53C
// Assembly location: C:\Users\mitch\.nuget\packages\vrising.unhollowed.client\0.6.5.57575090\lib\net6.0\ProjectM.Shared.dll

using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using System.Runtime.InteropServices;
using Unity.Burst;

#nullable disable
namespace ProjectM
{
  public class FactionRelationships : Il2CppSystem.Object
  {
    private static readonly System.IntPtr NativeFieldInfoPtr_MAX_FACTIONS;
    private static readonly System.IntPtr NativeFieldInfoPtr_Membership;
    private static readonly System.IntPtr NativeFieldInfoPtr_Friendly;
    private static readonly System.IntPtr NativeFieldInfoPtr_Neutral;
    private static readonly System.IntPtr NativeFieldInfoPtr_Hostile;
    private static readonly System.IntPtr NativeMethodInfoPtr_IsFriendly_Public_Static_Boolean_Int32_Int32_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_IsNeutral_Public_Static_Boolean_Int32_Int32_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_IsHostile_Public_Static_Boolean_Int32_Int32_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_HasRelation_Private_Static_Boolean_Int32_Int32_byref_SharedStatic_1_Flags_0;
    private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Protected_Void_0;

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 751035, XrefRangeEnd = 751048, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public static unsafe bool IsFriendly(int factionIndex, int targetFactionIndex)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[2];
      numPtr[0] = (System.IntPtr) &factionIndex;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &targetFactionIndex;
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(FactionRelationships.NativeMethodInfoPtr_IsFriendly_Public_Static_Boolean_Int32_Int32_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(bool*) IL2CPP.il2cpp_object_unbox(num);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 751048, XrefRangeEnd = 751061, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public static unsafe bool IsNeutral(int factionIndex, int targetFactionIndex)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[2];
      numPtr[0] = (System.IntPtr) &factionIndex;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &targetFactionIndex;
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(FactionRelationships.NativeMethodInfoPtr_IsNeutral_Public_Static_Boolean_Int32_Int32_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(bool*) IL2CPP.il2cpp_object_unbox(num);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 751061, XrefRangeEnd = 751074, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public static unsafe bool IsHostile(int factionIndex, int targetFactionIndex)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[2];
      numPtr[0] = (System.IntPtr) &factionIndex;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &targetFactionIndex;
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(FactionRelationships.NativeMethodInfoPtr_IsHostile_Public_Static_Boolean_Int32_Int32_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(bool*) IL2CPP.il2cpp_object_unbox(num);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 751074, XrefRangeEnd = 751083, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public static unsafe bool HasRelation(
      int factionIndex,
      int targetFactionIndex,
      [In] ref SharedStatic<FactionRelationships.Flags> array)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[3];
      numPtr[0] = (System.IntPtr) &factionIndex;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &targetFactionIndex;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = (System.IntPtr) ref array;
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(FactionRelationships.NativeMethodInfoPtr_HasRelation_Private_Static_Boolean_Int32_Int32_byref_SharedStatic_1_Flags_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(bool*) IL2CPP.il2cpp_object_unbox(num);
    }

    [CallerCount(3875)]
    [CachedScanResults(RefRangeStart = 16608, RefRangeEnd = 20483, XrefRangeStart = 16608, XrefRangeEnd = 20483, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe FactionRelationships()
      : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<FactionRelationships>.NativeClassPtr))
    {
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(FactionRelationships.NativeMethodInfoPtr__ctor_Protected_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    static FactionRelationships()
    {
      Il2CppClassPointerStore<FactionRelationships>.NativeClassPtr = IL2CPP.GetIl2CppClass("ProjectM.Shared.dll", "ProjectM", nameof (FactionRelationships));
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<FactionRelationships>.NativeClassPtr);
      FactionRelationships.NativeFieldInfoPtr_MAX_FACTIONS = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FactionRelationships>.NativeClassPtr, nameof (MAX_FACTIONS));
      FactionRelationships.NativeFieldInfoPtr_Membership = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FactionRelationships>.NativeClassPtr, nameof (Membership));
      FactionRelationships.NativeFieldInfoPtr_Friendly = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FactionRelationships>.NativeClassPtr, nameof (Friendly));
      FactionRelationships.NativeFieldInfoPtr_Neutral = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FactionRelationships>.NativeClassPtr, nameof (Neutral));
      FactionRelationships.NativeFieldInfoPtr_Hostile = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FactionRelationships>.NativeClassPtr, nameof (Hostile));
      FactionRelationships.NativeMethodInfoPtr_IsFriendly_Public_Static_Boolean_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FactionRelationships>.NativeClassPtr, 100666131);
      FactionRelationships.NativeMethodInfoPtr_IsNeutral_Public_Static_Boolean_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FactionRelationships>.NativeClassPtr, 100666132);
      FactionRelationships.NativeMethodInfoPtr_IsHostile_Public_Static_Boolean_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FactionRelationships>.NativeClassPtr, 100666133);
      FactionRelationships.NativeMethodInfoPtr_HasRelation_Private_Static_Boolean_Int32_Int32_byref_SharedStatic_1_Flags_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FactionRelationships>.NativeClassPtr, 100666134);
      FactionRelationships.NativeMethodInfoPtr__ctor_Protected_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FactionRelationships>.NativeClassPtr, 100666135);
    }

    public FactionRelationships(System.IntPtr pointer)
      : base(pointer)
    {
    }

    public static unsafe int MAX_FACTIONS
    {
      get
      {
        int maxFactions;
        IL2CPP.il2cpp_field_static_get_value(FactionRelationships.NativeFieldInfoPtr_MAX_FACTIONS, (void*) &maxFactions);
        return maxFactions;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(FactionRelationships.NativeFieldInfoPtr_MAX_FACTIONS, (void*) &value);
      }
    }

    public static unsafe SharedStatic<FactionRelationships.Flags> Membership
    {
      get
      {
        SharedStatic<FactionRelationships.Flags> membership;
        IL2CPP.il2cpp_field_static_get_value(FactionRelationships.NativeFieldInfoPtr_Membership, (void*) &membership);
        return membership;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(FactionRelationships.NativeFieldInfoPtr_Membership, (void*) &value);
      }
    }

    public static unsafe SharedStatic<FactionRelationships.Flags> Friendly
    {
      get
      {
        SharedStatic<FactionRelationships.Flags> friendly;
        IL2CPP.il2cpp_field_static_get_value(FactionRelationships.NativeFieldInfoPtr_Friendly, (void*) &friendly);
        return friendly;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(FactionRelationships.NativeFieldInfoPtr_Friendly, (void*) &value);
      }
    }

    public static unsafe SharedStatic<FactionRelationships.Flags> Neutral
    {
      get
      {
        SharedStatic<FactionRelationships.Flags> neutral;
        IL2CPP.il2cpp_field_static_get_value(FactionRelationships.NativeFieldInfoPtr_Neutral, (void*) &neutral);
        return neutral;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(FactionRelationships.NativeFieldInfoPtr_Neutral, (void*) &value);
      }
    }

    public static unsafe SharedStatic<FactionRelationships.Flags> Hostile
    {
      get
      {
        SharedStatic<FactionRelationships.Flags> hostile;
        IL2CPP.il2cpp_field_static_get_value(FactionRelationships.NativeFieldInfoPtr_Hostile, (void*) &hostile);
        return hostile;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(FactionRelationships.NativeFieldInfoPtr_Hostile, (void*) &value);
      }
    }

    [StructLayout(LayoutKind.Explicit)]
    public struct Flags
    {
      private static readonly System.IntPtr NativeFieldInfoPtr_State;
      [FieldOffset(0)]
      public FactionRelationships.Flags._State_e__FixedBuffer State;

      static Flags()
      {
        Il2CppClassPointerStore<FactionRelationships.Flags>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<FactionRelationships>.NativeClassPtr, nameof (Flags));
        IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<FactionRelationships.Flags>.NativeClassPtr);
        FactionRelationships.Flags.NativeFieldInfoPtr_State = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FactionRelationships.Flags>.NativeClassPtr, nameof (State));
      }

      public Il2CppSystem.Object BoxIl2CppObject()
      {
        return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<FactionRelationships.Flags>.NativeClassPtr, (System.IntPtr) ref this));
      }

      [ObfuscatedName("ProjectM.FactionRelationships/Flags/<State>e__FixedBuffer")]
      [StructLayout(LayoutKind.Explicit)]
      public struct _State_e__FixedBuffer
      {
        private static readonly System.IntPtr NativeFieldInfoPtr_FixedElementField;
        [FieldOffset(0)]
        public int FixedElementField;

        static _State_e__FixedBuffer()
        {
          Il2CppClassPointerStore<FactionRelationships.Flags._State_e__FixedBuffer>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<FactionRelationships.Flags>.NativeClassPtr, "<State>e__FixedBuffer");
          IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<FactionRelationships.Flags._State_e__FixedBuffer>.NativeClassPtr);
          FactionRelationships.Flags._State_e__FixedBuffer.NativeFieldInfoPtr_FixedElementField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FactionRelationships.Flags._State_e__FixedBuffer>.NativeClassPtr, nameof (FixedElementField));
        }

        public Il2CppSystem.Object BoxIl2CppObject()
        {
          return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<FactionRelationships.Flags._State_e__FixedBuffer>.NativeClassPtr, (System.IntPtr) ref this));
        }
      }
    }

    public class MembershipDataFieldKey : Il2CppSystem.Object
    {
      private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

      [CallerCount(3875)]
      [CachedScanResults(RefRangeStart = 16608, RefRangeEnd = 20483, XrefRangeStart = 16608, XrefRangeEnd = 20483, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe MembershipDataFieldKey()
        : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<FactionRelationships.MembershipDataFieldKey>.NativeClassPtr))
      {
        System.IntPtr* numPtr = (System.IntPtr*) null;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(FactionRelationships.MembershipDataFieldKey.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      static MembershipDataFieldKey()
      {
        Il2CppClassPointerStore<FactionRelationships.MembershipDataFieldKey>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<FactionRelationships>.NativeClassPtr, nameof (MembershipDataFieldKey));
        IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<FactionRelationships.MembershipDataFieldKey>.NativeClassPtr);
        FactionRelationships.MembershipDataFieldKey.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FactionRelationships.MembershipDataFieldKey>.NativeClassPtr, 100666137);
      }

      public MembershipDataFieldKey(System.IntPtr pointer)
        : base(pointer)
      {
      }
    }

    public class FriendlyDataFieldKey : Il2CppSystem.Object
    {
      private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

      [CallerCount(3875)]
      [CachedScanResults(RefRangeStart = 16608, RefRangeEnd = 20483, XrefRangeStart = 16608, XrefRangeEnd = 20483, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe FriendlyDataFieldKey()
        : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<FactionRelationships.FriendlyDataFieldKey>.NativeClassPtr))
      {
        System.IntPtr* numPtr = (System.IntPtr*) null;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(FactionRelationships.FriendlyDataFieldKey.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      static FriendlyDataFieldKey()
      {
        Il2CppClassPointerStore<FactionRelationships.FriendlyDataFieldKey>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<FactionRelationships>.NativeClassPtr, nameof (FriendlyDataFieldKey));
        IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<FactionRelationships.FriendlyDataFieldKey>.NativeClassPtr);
        FactionRelationships.FriendlyDataFieldKey.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FactionRelationships.FriendlyDataFieldKey>.NativeClassPtr, 100666138);
      }

      public FriendlyDataFieldKey(System.IntPtr pointer)
        : base(pointer)
      {
      }
    }

    public class NeutralDataFieldKey : Il2CppSystem.Object
    {
      private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

      [CallerCount(3875)]
      [CachedScanResults(RefRangeStart = 16608, RefRangeEnd = 20483, XrefRangeStart = 16608, XrefRangeEnd = 20483, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe NeutralDataFieldKey()
        : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<FactionRelationships.NeutralDataFieldKey>.NativeClassPtr))
      {
        System.IntPtr* numPtr = (System.IntPtr*) null;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(FactionRelationships.NeutralDataFieldKey.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      static NeutralDataFieldKey()
      {
        Il2CppClassPointerStore<FactionRelationships.NeutralDataFieldKey>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<FactionRelationships>.NativeClassPtr, nameof (NeutralDataFieldKey));
        IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<FactionRelationships.NeutralDataFieldKey>.NativeClassPtr);
        FactionRelationships.NeutralDataFieldKey.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FactionRelationships.NeutralDataFieldKey>.NativeClassPtr, 100666139);
      }

      public NeutralDataFieldKey(System.IntPtr pointer)
        : base(pointer)
      {
      }
    }

    public class HostileDataFieldKey : Il2CppSystem.Object
    {
      private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

      [CallerCount(3875)]
      [CachedScanResults(RefRangeStart = 16608, RefRangeEnd = 20483, XrefRangeStart = 16608, XrefRangeEnd = 20483, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe HostileDataFieldKey()
        : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<FactionRelationships.HostileDataFieldKey>.NativeClassPtr))
      {
        System.IntPtr* numPtr = (System.IntPtr*) null;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(FactionRelationships.HostileDataFieldKey.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      static HostileDataFieldKey()
      {
        Il2CppClassPointerStore<FactionRelationships.HostileDataFieldKey>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<FactionRelationships>.NativeClassPtr, nameof (HostileDataFieldKey));
        IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<FactionRelationships.HostileDataFieldKey>.NativeClassPtr);
        FactionRelationships.HostileDataFieldKey.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FactionRelationships.HostileDataFieldKey>.NativeClassPtr, 100666140);
      }

      public HostileDataFieldKey(System.IntPtr pointer)
        : base(pointer)
      {
      }
    }
  }
}
