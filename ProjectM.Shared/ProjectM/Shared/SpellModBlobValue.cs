// Decompiled with JetBrains decompiler
// Type: ProjectM.Shared.SpellModBlobValue
// Assembly: ProjectM.Shared, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: CF03A298-FF93-4294-AFD6-565AD334A53C
// Assembly location: C:\Users\mitch\.nuget\packages\vrising.unhollowed.client\0.6.5.57575090\lib\net6.0\ProjectM.Shared.dll

using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using System.Runtime.InteropServices;
using Unity.Collections;

#nullable disable
namespace ProjectM.Shared
{
  [StructLayout(LayoutKind.Explicit)]
  public struct SpellModBlobValue
  {
    private static readonly System.IntPtr NativeFieldInfoPtr_Name;
    private static readonly System.IntPtr NativeFieldInfoPtr_Data;
    private static readonly System.IntPtr NativeFieldInfoPtr_Type;
    private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_SpellModEvaluator_Object_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_TryGetSpellMod_Public_Boolean_byref_SpellModValue_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_TryGetStatMod_Public_Boolean_byref_StatModValue_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_TryGetPrefabGUIDMod_Public_Boolean_byref_PrefabModValue_0;
    [FieldOffset(0)]
    public FixedString64 Name;
    [FieldOffset(64)]
    public SpellModBlobUnion Data;
    [FieldOffset(84)]
    public SpellModBlobValue.ModType Type;

    [CallerCount(3)]
    [CachedScanResults(RefRangeStart = 798594, RefRangeEnd = 798597, XrefRangeStart = 798587, XrefRangeEnd = 798594, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe SpellModBlobValue(SpellModEvaluator evaluator, UnityEngine.Object source)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[2];
      numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) evaluator);
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) source);
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(SpellModBlobValue.NativeMethodInfoPtr__ctor_Public_Void_SpellModEvaluator_Object_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(8)]
    [CachedScanResults(RefRangeStart = 798597, RefRangeEnd = 798605, XrefRangeStart = 798597, XrefRangeEnd = 798597, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe bool TryGetSpellMod(out SpellModValue value)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[1];
      numPtr[0] = (System.IntPtr) ref value;
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(SpellModBlobValue.NativeMethodInfoPtr_TryGetSpellMod_Public_Boolean_byref_SpellModValue_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(bool*) IL2CPP.il2cpp_object_unbox(num);
    }

    [CallerCount(2)]
    [CachedScanResults(RefRangeStart = 798605, RefRangeEnd = 798607, XrefRangeStart = 798605, XrefRangeEnd = 798605, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe bool TryGetStatMod(out StatModValue value)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[1];
      numPtr[0] = (System.IntPtr) ref value;
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(SpellModBlobValue.NativeMethodInfoPtr_TryGetStatMod_Public_Boolean_byref_StatModValue_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(bool*) IL2CPP.il2cpp_object_unbox(num);
    }

    [CallerCount(2)]
    [CachedScanResults(RefRangeStart = 798607, RefRangeEnd = 798609, XrefRangeStart = 798607, XrefRangeEnd = 798607, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe bool TryGetPrefabGUIDMod(out PrefabModValue value)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[1];
      numPtr[0] = (System.IntPtr) ref value;
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(SpellModBlobValue.NativeMethodInfoPtr_TryGetPrefabGUIDMod_Public_Boolean_byref_PrefabModValue_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(bool*) IL2CPP.il2cpp_object_unbox(num);
    }

    static SpellModBlobValue()
    {
      Il2CppClassPointerStore<SpellModBlobValue>.NativeClassPtr = IL2CPP.GetIl2CppClass("ProjectM.Shared.dll", "ProjectM.Shared", nameof (SpellModBlobValue));
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<SpellModBlobValue>.NativeClassPtr);
      SpellModBlobValue.NativeFieldInfoPtr_Name = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SpellModBlobValue>.NativeClassPtr, nameof (Name));
      SpellModBlobValue.NativeFieldInfoPtr_Data = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SpellModBlobValue>.NativeClassPtr, nameof (Data));
      SpellModBlobValue.NativeFieldInfoPtr_Type = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SpellModBlobValue>.NativeClassPtr, nameof (Type));
      SpellModBlobValue.NativeMethodInfoPtr__ctor_Public_Void_SpellModEvaluator_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SpellModBlobValue>.NativeClassPtr, 100670424);
      SpellModBlobValue.NativeMethodInfoPtr_TryGetSpellMod_Public_Boolean_byref_SpellModValue_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SpellModBlobValue>.NativeClassPtr, 100670425);
      SpellModBlobValue.NativeMethodInfoPtr_TryGetStatMod_Public_Boolean_byref_StatModValue_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SpellModBlobValue>.NativeClassPtr, 100670426);
      SpellModBlobValue.NativeMethodInfoPtr_TryGetPrefabGUIDMod_Public_Boolean_byref_PrefabModValue_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SpellModBlobValue>.NativeClassPtr, 100670427);
    }

    public Il2CppSystem.Object BoxIl2CppObject()
    {
      return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<SpellModBlobValue>.NativeClassPtr, (System.IntPtr) ref this));
    }

    public enum ModType : byte
    {
      None,
      SpellMod,
      StatMod,
      PrefabGuidMod,
    }
  }
}
