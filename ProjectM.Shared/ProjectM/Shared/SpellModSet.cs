// Decompiled with JetBrains decompiler
// Type: ProjectM.Shared.SpellModSet
// Assembly: ProjectM.Shared, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: CF03A298-FF93-4294-AFD6-565AD334A53C
// Assembly location: C:\Users\mitch\.nuget\packages\vrising.unhollowed.client\0.6.5.57575090\lib\net6.0\ProjectM.Shared.dll

using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using System.Runtime.InteropServices;

#nullable disable
namespace ProjectM.Shared
{
  [StructLayout(LayoutKind.Explicit)]
  public struct SpellModSet
  {
    private static readonly System.IntPtr NativeFieldInfoPtr_SyncId;
    private static readonly System.IntPtr NativeFieldInfoPtr_Mod0;
    private static readonly System.IntPtr NativeFieldInfoPtr_Mod1;
    private static readonly System.IntPtr NativeFieldInfoPtr_Mod2;
    private static readonly System.IntPtr NativeFieldInfoPtr_Mod3;
    private static readonly System.IntPtr NativeFieldInfoPtr_Mod4;
    private static readonly System.IntPtr NativeFieldInfoPtr_Mod5;
    private static readonly System.IntPtr NativeFieldInfoPtr_Mod6;
    private static readonly System.IntPtr NativeFieldInfoPtr_Mod7;
    private static readonly System.IntPtr NativeFieldInfoPtr_Count;
    private static readonly System.IntPtr NativeFieldInfoPtr_Capacity;
    private static readonly System.IntPtr NativeMethodInfoPtr_get_Item_Public_get_SpellMod_Int32_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_set_Item_Public_set_Void_Int32_SpellMod_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_TryGetSpellMod_Public_Boolean_PrefabGUID_byref_SpellMod_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_Equals_Public_Virtual_Final_New_Boolean_SpellModSet_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_Equals_Public_Virtual_Boolean_Object_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_GetHashCode_Public_Virtual_Int32_0;
    [FieldOffset(0)]
    public int SyncId;
    [FieldOffset(4)]
    public SpellMod Mod0;
    [FieldOffset(12)]
    public SpellMod Mod1;
    [FieldOffset(20)]
    public SpellMod Mod2;
    [FieldOffset(28)]
    public SpellMod Mod3;
    [FieldOffset(36)]
    public SpellMod Mod4;
    [FieldOffset(44)]
    public SpellMod Mod5;
    [FieldOffset(52)]
    public SpellMod Mod6;
    [FieldOffset(60)]
    public SpellMod Mod7;
    [FieldOffset(68)]
    public byte Count;

    public unsafe SpellMod this[int index]
    {
      [CallerCount(19), CachedScanResults(RefRangeStart = 798414, RefRangeEnd = 798433, XrefRangeStart = 798414, XrefRangeEnd = 798414, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] get
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[1];
        numPtr[0] = (System.IntPtr) &index;
        System.IntPtr exc;
        System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(SpellModSet.NativeMethodInfoPtr_get_Item_Public_get_SpellMod_Int32_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
        return *(SpellMod*) IL2CPP.il2cpp_object_unbox(num);
      }
      [CallerCount(9), CachedScanResults(RefRangeStart = 798433, RefRangeEnd = 798442, XrefRangeStart = 798433, XrefRangeEnd = 798433, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] set
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[2];
        numPtr[0] = (System.IntPtr) &index;
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &value;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(SpellModSet.NativeMethodInfoPtr_set_Item_Public_set_Void_Int32_SpellMod_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 798442, XrefRangeEnd = 798445, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe bool TryGetSpellMod(PrefabGUID spellModId, out SpellMod mod)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[2];
      numPtr[0] = (System.IntPtr) &spellModId;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) ref mod;
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(SpellModSet.NativeMethodInfoPtr_TryGetSpellMod_Public_Boolean_PrefabGUID_byref_SpellMod_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(bool*) IL2CPP.il2cpp_object_unbox(num);
    }

    [CallerCount(1)]
    [CachedScanResults(RefRangeStart = 798452, RefRangeEnd = 798453, XrefRangeStart = 798445, XrefRangeEnd = 798452, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public virtual unsafe bool Equals(SpellModSet other)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[1];
      numPtr[0] = (System.IntPtr) &other;
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(SpellModSet.NativeMethodInfoPtr_Equals_Public_Virtual_Final_New_Boolean_SpellModSet_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(bool*) IL2CPP.il2cpp_object_unbox(num);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 798453, XrefRangeEnd = 798457, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public virtual unsafe bool Equals(Il2CppSystem.Object obj)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[1];
      numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) obj);
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(SpellModSet.NativeMethodInfoPtr_Equals_Public_Virtual_Boolean_Object_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(bool*) IL2CPP.il2cpp_object_unbox(num);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 798457, XrefRangeEnd = 798461, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public override unsafe int GetHashCode()
    {
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(SpellModSet.NativeMethodInfoPtr_GetHashCode_Public_Virtual_Int32_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(int*) IL2CPP.il2cpp_object_unbox(num);
    }

    static SpellModSet()
    {
      Il2CppClassPointerStore<SpellModSet>.NativeClassPtr = IL2CPP.GetIl2CppClass("ProjectM.Shared.dll", "ProjectM.Shared", nameof (SpellModSet));
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<SpellModSet>.NativeClassPtr);
      SpellModSet.NativeFieldInfoPtr_SyncId = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SpellModSet>.NativeClassPtr, nameof (SyncId));
      SpellModSet.NativeFieldInfoPtr_Mod0 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SpellModSet>.NativeClassPtr, nameof (Mod0));
      SpellModSet.NativeFieldInfoPtr_Mod1 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SpellModSet>.NativeClassPtr, nameof (Mod1));
      SpellModSet.NativeFieldInfoPtr_Mod2 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SpellModSet>.NativeClassPtr, nameof (Mod2));
      SpellModSet.NativeFieldInfoPtr_Mod3 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SpellModSet>.NativeClassPtr, nameof (Mod3));
      SpellModSet.NativeFieldInfoPtr_Mod4 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SpellModSet>.NativeClassPtr, nameof (Mod4));
      SpellModSet.NativeFieldInfoPtr_Mod5 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SpellModSet>.NativeClassPtr, nameof (Mod5));
      SpellModSet.NativeFieldInfoPtr_Mod6 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SpellModSet>.NativeClassPtr, nameof (Mod6));
      SpellModSet.NativeFieldInfoPtr_Mod7 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SpellModSet>.NativeClassPtr, nameof (Mod7));
      SpellModSet.NativeFieldInfoPtr_Count = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SpellModSet>.NativeClassPtr, nameof (Count));
      SpellModSet.NativeFieldInfoPtr_Capacity = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SpellModSet>.NativeClassPtr, nameof (Capacity));
      SpellModSet.NativeMethodInfoPtr_get_Item_Public_get_SpellMod_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SpellModSet>.NativeClassPtr, 100670392);
      SpellModSet.NativeMethodInfoPtr_set_Item_Public_set_Void_Int32_SpellMod_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SpellModSet>.NativeClassPtr, 100670393);
      SpellModSet.NativeMethodInfoPtr_TryGetSpellMod_Public_Boolean_PrefabGUID_byref_SpellMod_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SpellModSet>.NativeClassPtr, 100670394);
      SpellModSet.NativeMethodInfoPtr_Equals_Public_Virtual_Final_New_Boolean_SpellModSet_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SpellModSet>.NativeClassPtr, 100670395);
      SpellModSet.NativeMethodInfoPtr_Equals_Public_Virtual_Boolean_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SpellModSet>.NativeClassPtr, 100670396);
      SpellModSet.NativeMethodInfoPtr_GetHashCode_Public_Virtual_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SpellModSet>.NativeClassPtr, 100670397);
    }

    public Il2CppSystem.Object BoxIl2CppObject()
    {
      return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<SpellModSet>.NativeClassPtr, (System.IntPtr) ref this));
    }

    public static unsafe int Capacity
    {
      get
      {
        int capacity;
        IL2CPP.il2cpp_field_static_get_value(SpellModSet.NativeFieldInfoPtr_Capacity, (void*) &capacity);
        return capacity;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(SpellModSet.NativeFieldInfoPtr_Capacity, (void*) &value);
      }
    }
  }
}
