// Decompiled with JetBrains decompiler
// Type: ProjectM.Sequencer.SequenceGraphHelper
// Assembly: ProjectM, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 83E42B70-D81B-4F1F-9FB5-6B5ABD5FF9FC
// Assembly location: C:\Users\mitch\.nuget\packages\vrising.unhollowed.client\0.6.5.57575090\lib\net6.0\ProjectM.dll

using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Stunlock.Sequencer;
using UnityEngine;

#nullable disable
namespace ProjectM.Sequencer
{
  public static class SequenceGraphHelper : Il2CppSystem.Object
  {
    private static readonly System.IntPtr NativeMethodInfoPtr_SocketTypeToShortString_Public_Static_String_BlackboardRegisterType_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_SocketTypeHelpString_Public_Static_String_BlackboardRegisterType_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_NodeTypeToName_Public_Static_String_GraphFunction_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_ConvertCamelCase_Public_Static_String_String_Boolean_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_GetColorByType_Public_Static_Color_BlackboardRegisterType_0;

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1095296, XrefRangeEnd = 1095312, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public static unsafe string SocketTypeToShortString(BlackboardRegisterType type)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[1];
      numPtr[0] = (System.IntPtr) &type;
      System.IntPtr exc;
      System.IntPtr il2CppString = IL2CPP.il2cpp_runtime_invoke(SequenceGraphHelper.NativeMethodInfoPtr_SocketTypeToShortString_Public_Static_String_BlackboardRegisterType_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return IL2CPP.Il2CppStringToManaged(il2CppString);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1095312, XrefRangeEnd = 1095325, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public static unsafe string SocketTypeHelpString(BlackboardRegisterType socketType)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[1];
      numPtr[0] = (System.IntPtr) &socketType;
      System.IntPtr exc;
      System.IntPtr il2CppString = IL2CPP.il2cpp_runtime_invoke(SequenceGraphHelper.NativeMethodInfoPtr_SocketTypeHelpString_Public_Static_String_BlackboardRegisterType_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return IL2CPP.Il2CppStringToManaged(il2CppString);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1095325, XrefRangeEnd = 1095331, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public static unsafe string NodeTypeToName(GraphFunction type)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[1];
      numPtr[0] = (System.IntPtr) &type;
      System.IntPtr exc;
      System.IntPtr il2CppString = IL2CPP.il2cpp_runtime_invoke(SequenceGraphHelper.NativeMethodInfoPtr_NodeTypeToName_Public_Static_String_GraphFunction_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return IL2CPP.Il2CppStringToManaged(il2CppString);
    }

    [CallerCount(3)]
    [CachedScanResults(RefRangeStart = 1095362, RefRangeEnd = 1095365, XrefRangeStart = 1095331, XrefRangeEnd = 1095362, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public static unsafe string ConvertCamelCase(string text, bool preserveAcronyms = true)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[2];
      numPtr[0] = IL2CPP.ManagedStringToIl2Cpp(text);
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &preserveAcronyms;
      System.IntPtr exc;
      System.IntPtr il2CppString = IL2CPP.il2cpp_runtime_invoke(SequenceGraphHelper.NativeMethodInfoPtr_ConvertCamelCase_Public_Static_String_String_Boolean_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return IL2CPP.Il2CppStringToManaged(il2CppString);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1095365, XrefRangeEnd = 1095397, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public static unsafe Color GetColorByType(BlackboardRegisterType socketType)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[1];
      numPtr[0] = (System.IntPtr) &socketType;
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(SequenceGraphHelper.NativeMethodInfoPtr_GetColorByType_Public_Static_Color_BlackboardRegisterType_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(Color*) IL2CPP.il2cpp_object_unbox(num);
    }

    static SequenceGraphHelper()
    {
      Il2CppClassPointerStore<SequenceGraphHelper>.NativeClassPtr = IL2CPP.GetIl2CppClass("ProjectM.dll", "ProjectM.Sequencer", nameof (SequenceGraphHelper));
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<SequenceGraphHelper>.NativeClassPtr);
      SequenceGraphHelper.NativeMethodInfoPtr_SocketTypeToShortString_Public_Static_String_BlackboardRegisterType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SequenceGraphHelper>.NativeClassPtr, 100686818);
      SequenceGraphHelper.NativeMethodInfoPtr_SocketTypeHelpString_Public_Static_String_BlackboardRegisterType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SequenceGraphHelper>.NativeClassPtr, 100686819);
      SequenceGraphHelper.NativeMethodInfoPtr_NodeTypeToName_Public_Static_String_GraphFunction_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SequenceGraphHelper>.NativeClassPtr, 100686820);
      SequenceGraphHelper.NativeMethodInfoPtr_ConvertCamelCase_Public_Static_String_String_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SequenceGraphHelper>.NativeClassPtr, 100686821);
      SequenceGraphHelper.NativeMethodInfoPtr_GetColorByType_Public_Static_Color_BlackboardRegisterType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SequenceGraphHelper>.NativeClassPtr, 100686822);
    }

    public SequenceGraphHelper(System.IntPtr pointer)
      : base(pointer)
    {
    }
  }
}
