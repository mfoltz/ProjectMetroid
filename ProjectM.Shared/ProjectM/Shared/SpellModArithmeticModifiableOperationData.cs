// Decompiled with JetBrains decompiler
// Type: ProjectM.Shared.SpellModArithmeticModifiableOperationData
// Assembly: ProjectM.Shared, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: CF03A298-FF93-4294-AFD6-565AD334A53C
// Assembly location: C:\Users\mitch\.nuget\packages\vrising.unhollowed.client\0.6.5.57575090\lib\net6.0\ProjectM.Shared.dll

using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using System.Runtime.InteropServices;
using Unity.Entities;

#nullable disable
namespace ProjectM.Shared
{
  [StructLayout(LayoutKind.Explicit)]
  public struct SpellModArithmeticModifiableOperationData
  {
    private static readonly System.IntPtr NativeFieldInfoPtr_Structure;
    private static readonly System.IntPtr NativeFieldInfoPtr_Buffer;
    private static readonly System.IntPtr NativeFieldInfoPtr_SpellModSet;
    private static readonly System.IntPtr NativeFieldInfoPtr_Target;
    private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_byref_ModificationStructure_byref_DynamicBuffer_1_FloatModificationBuffer_Entity_Entity_0;
    [FieldOffset(0)]
    public readonly ModificationStructure Structure;
    [FieldOffset(32)]
    public DynamicBuffer<FloatModificationBuffer> Buffer;
    [FieldOffset(48)]
    public readonly Entity SpellModSet;
    [FieldOffset(56)]
    public readonly Entity Target;

    [CallerCount(1)]
    [CachedScanResults(RefRangeStart = 798512, RefRangeEnd = 798513, XrefRangeStart = 798512, XrefRangeEnd = 798512, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe SpellModArithmeticModifiableOperationData(
      [In] ref ModificationStructure structure,
      ref DynamicBuffer<FloatModificationBuffer> buffer,
      Entity spellModSet,
      Entity target)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[4];
      numPtr[0] = (System.IntPtr) ref structure;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) ref buffer;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = (System.IntPtr) &spellModSet;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(3) * sizeof (System.IntPtr))) = (System.IntPtr) &target;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(SpellModArithmeticModifiableOperationData.NativeMethodInfoPtr__ctor_Public_Void_byref_ModificationStructure_byref_DynamicBuffer_1_FloatModificationBuffer_Entity_Entity_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    static SpellModArithmeticModifiableOperationData()
    {
      Il2CppClassPointerStore<SpellModArithmeticModifiableOperationData>.NativeClassPtr = IL2CPP.GetIl2CppClass("ProjectM.Shared.dll", "ProjectM.Shared", nameof (SpellModArithmeticModifiableOperationData));
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<SpellModArithmeticModifiableOperationData>.NativeClassPtr);
      SpellModArithmeticModifiableOperationData.NativeFieldInfoPtr_Structure = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SpellModArithmeticModifiableOperationData>.NativeClassPtr, nameof (Structure));
      SpellModArithmeticModifiableOperationData.NativeFieldInfoPtr_Buffer = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SpellModArithmeticModifiableOperationData>.NativeClassPtr, nameof (Buffer));
      SpellModArithmeticModifiableOperationData.NativeFieldInfoPtr_SpellModSet = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SpellModArithmeticModifiableOperationData>.NativeClassPtr, nameof (SpellModSet));
      SpellModArithmeticModifiableOperationData.NativeFieldInfoPtr_Target = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SpellModArithmeticModifiableOperationData>.NativeClassPtr, nameof (Target));
      SpellModArithmeticModifiableOperationData.NativeMethodInfoPtr__ctor_Public_Void_byref_ModificationStructure_byref_DynamicBuffer_1_FloatModificationBuffer_Entity_Entity_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SpellModArithmeticModifiableOperationData>.NativeClassPtr, 100670407);
    }

    public Il2CppSystem.Object BoxIl2CppObject()
    {
      return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<SpellModArithmeticModifiableOperationData>.NativeClassPtr, (System.IntPtr) ref this));
    }
  }
}
